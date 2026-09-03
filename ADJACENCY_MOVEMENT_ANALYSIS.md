# Adjacency & Movement Logic Reference

## Vanilla Game Definitions

### IsAdjacent(region, invasionArmy)
```csharp
bool IsAdjacent(TIRegionState region, bool IAmAnInvadingArmy)
{
	switch (this.GetAdjacencyType(region))
	{
	case TerrestrialAdjacencyType.None:
		return false;
	case TerrestrialAdjacencyType.FriendlyCrossingOnly:
		return !IAmAnInvadingArmy;  // false = peaceful, true = invasion
	case TerrestrialAdjacencyType.FullAdjacency:
		return true;
	}
}
```

**For discontiguity:** Use `IsAdjacent(region, false)` — peaceful/non-invading mode

### AdjacentRegions(IAmAnInvadingArmy)
```csharp
List<TIRegionState> AdjacentRegions(bool IAmAnInvadingArmy)
{
	if (!IAmAnInvadingArmy)
		return this.adjacencies.Keys.ToList();  // All adjacencies

	return this.adjacencies.Keys
		.Where(region => adjacencies[region] == TerrestrialAdjacencyType.FullAdjacency)
		.ToList();  // Only FullAdjacency
}
```

**For discontiguity:** Use `current.Neighbors` (equivalent to `AdjacentRegions(false)`)

### Neighbors Property
```csharp
// Alias for AdjacentRegions(false)
// Returns ALL adjacent regions regardless of adjacency type
// Fastest way to get adjacent regions
```

---

## Adjacency Types Explained

| Type | Peaceful Movement | Invasion | Example |
|------|------------------|----------|---------|
| **FullAdjacency** | ✅ Yes | ✅ Yes | Land borders |
| **FriendlyCrossingOnly** | ✅ Yes | ❌ No | Neutral passage agreements |
| **None** | ❌ No | ❌ No | Non-adjacent regions |

---

## Army vs Nation Contiguity

### Army Viable Movement
```csharp
// Starts: Current position
// Can traverse: Own + Allies + Enemies (if at war)
// Adjacency: Depends on conflict status
// Use case: "Can this army reach that region?"
// Implementation: TIArmyState.CanGetTo() with bidirectional BFS
```

### Nation Contiguity
```csharp
// Starts: Capital
// Can traverse: Own + Unclaimed (NO enemies)
// Adjacency: Always peaceful (IsAdjacent(..., false))
// Use case: "Is this region structurally connected?"
// Implementation: GetTrueContiguousRegions() with single-source BFS
```

---

## Performance Optimization Applied

### BEFORE (Old Implementation)
```csharp
TIRegionState[] allRegions = GameStateManager.AllRegions();  // ~1000 regions
foreach (TIRegionState potentialNeighbor in allRegions)
{
	// Check all 1000 regions from EVERY queued region
}
// Result: O(n²) complexity = 1000 * 1000 = 1,000,000 checks per BFS
```

**Performance:** Scales poorly, becomes unusable with large territories

### AFTER (New Implementation)
```csharp
foreach (TIRegionState neighbor in current.Neighbors)
{
	// Only check ~3-6 actual neighbors
}
// Result: O(n) complexity = 1000 * 4 = 4,000 checks per BFS
```

**Performance:** ~250x faster, scales linearly with territory size

---

## When to Use Each Method

```csharp
// ✅ PREFERRED: Iterate adjacent regions (fast, clean)
foreach (TIRegionState neighbor in region.Neighbors)
{ }

// ✅ GOOD: Check if two regions are adjacent
if (regionA.IsAdjacent(regionB, false))  // false = peaceful
{ }

// ✅ SPECIALIZED: Get specific adjacency type
TerrestrialAdjacencyType type = regionA.GetAdjacencyType(regionB);

// ❌ AVOID: Check all regions (O(n²) performance)
TIRegionState[] allRegions = GameStateManager.AllRegions();  
```

---

## Discontiguity Calculation Algorithm

```csharp
HashSet<TIRegionState> GetContiguousRegions(TINationState nation)
{
	HashSet<TIRegionState> result = new();
	Queue<TIRegionState> queue = new();

	// Start from capital
	queue.Enqueue(nation.capital);
	result.Add(nation.capital);

	// BFS expansion
	while (queue.Count > 0)
	{
		TIRegionState current = queue.Dequeue();

		// USE current.Neighbors - NOT GameStateManager.AllRegions()
		foreach (TIRegionState neighbor in current.Neighbors)
		{
			if (result.Contains(neighbor))
				continue;  // Already visited

			// Check adjacency type is traversable
			if (!neighbor.IsAdjacent(current, false))
				continue;  // Not peaceful adjacency

			// Must be owned by this nation (enemies are blockers)
			if (neighbor.nation != null && neighbor.nation != nation)
				continue;  // Blocked by another nation

			// Add to connected territory
			result.Add(neighbor);
			queue.Enqueue(neighbor);
		}
	}

	return result;
}
```

---

## Why Vanilla Army Code Doesn't Apply

| Aspect | Army Movement | Discontiguity |
|--------|----------------|--------------|
| **Problem** | Military logistics | Structural connectivity |
| **Context** | Considers wars, allies | Ignores diplomatic status |
| **Algorithm** | Bidirectional BFS | Single-source BFS |
| **Complexity** | O(frontier) expansion | O(n) simple expansion |
| **Caching** | Frame/7-day optimized | On-demand calculation |
| **Reuse Factor** | Low - different domains | Can use adjacency primitives |

**Conclusion:** Only leverage vanilla's `IsAdjacent()` and `Neighbors`, not the pathfinding algorithm.

---

## Debug Checklist

- [ ] `EnableDebugLogging = true` in mod settings
- [ ] Check for `[Discontiguity]` log entries
- [ ] Verify penalty values are ≤ 0 (penalty/malus)
- [ ] Confirm penalty added to final `total` cohesion
- [ ] Check `DiscontiguousPopulation` values are realistic
- [ ] Test with isolated island regions

---

## Common Pitfalls to Avoid

### ❌ WRONG: Brute-force region checking
```csharp
TIRegionState[] allRegions = GameStateManager.AllRegions();
foreach (var r in allRegions)
	if (r.IsAdjacent(current, false))
		// Most iterations waste on non-adjacent regions
```

### ✅ CORRECT: Use vanilla's neighbor tracking
```csharp
foreach (var neighbor in current.Neighbors)
	if (neighbor.IsAdjacent(current, false))
		// Only check actual neighbors
```

### ❌ WRONG: Using army movement for contiguity
```csharp
var reachable = army.ReachableRegions;  // Includes allies, enemies!
```

### ✅ CORRECT: Simple BFS with nation-specific rules
```csharp
var contiguous = nation.GetTrueContiguousRegions();  // Only own regions
```

---

## Key Takeaways

1. **Adjacency primitives:** Use vanilla's `IsAdjacent()`, `Neighbors`, `GetAdjacencyType()`
2. **Iteration strategy:** Use `current.Neighbors` NOT `GameStateManager.AllRegions()`
3. **Don't overengineer:** Don't use army pathfinding for structural contiguity
4. **Parameters matter:** Always be clear about `IsAdjacent(region, invasionArmy)` boolean
5. **Performance: ~250x faster** by switching from O(n²) to O(n) iteration

---

## File Changes Summary

**Modified:** `CreepingBordersCls.cs` - `GetTrueContiguousRegions()` method
- **Before:** Iterated `GameStateManager.AllRegions()` (~1000 regions)
- **After:** Iterates `current.Neighbors` (~4-6 regions)
- **Result:** No behavioral change, 250x performance improvement

**Added:** Detailed code comments explaining adjacency logic and reasoning
