# Army Movement & Discontiguity Calculation Analysis

## Executive Summary
The vanilla army movement calculation can **partially** simplify discontiguity calculations, but with important caveats. The army's viable movement uses bidirectional BFS pathfinding with sophisticated naval support logic, while discontiguity just needs simple contiguity checking. Using army movement code would be **over-engineering** and less efficient.

---

## 1. How Vanilla Army Viable Movement is Calculated

### For an Army with NO Navy in a Nation with NO Allies

**Key Method:** `TIArmyState.CanGetTo()`

#### Prerequisites:
- Army has `deploymentType != DeploymentType.Naval` (or has no naval freedom)
- Nation has no allies (both directions checked)
- Nation has no wars (so no enemy movement options)

#### Algorithm Flow:

1. **Enterable Regions Check**
   ```
   Regions the army can enter = 
	   - Own nation's regions
	   - Allied nations' regions (none in this case)
	   - Enemy nations' regions (none in this case)
   ```

2. **Bidirectional BFS Pathfinding**
   - Starts queues from both origin and destination simultaneously
   - Searches outward in both directions until paths meet
   - Avoids fully exploring the entire map space

3. **For Non-Naval Armies (Ground/Air):**
   ```
   Valid neighbors = regions where:
	   - IsAdjacent(current, neighbor, false) returns true
	   - (i.e., adjacency type is FullAdjacency OR FriendlyCrossingOnly)
	   - Neighbor is enterable by the army
   ```

4. **Adjacency Rules:**
   - `FullAdjacency`: Can move freely regardless of conflict status
   - `FriendlyCrossingOnly`: Can move ONLY if no war with that nation
   - `None`: Cannot move at all

5. **Result:** Set of all reachable regions from current position

### Complexity Factors
- **Bidirectional search:** More efficient than unidirectional
- **Caching:** `ReachableRegions` cached per frame, `ReachableRegions_Fast` cached per 7 days
- **Naval logic:** Adds water body traversal complexity (not relevant here)
- **Queue-based iteration:** O(n) regions, each checking O(k) neighbors

---

## 2. Current Discontiguity Calculation

### Your `GetTrueContiguousRegions()` Method

```csharp
// BFS from capital, only traversing through owned or unclaimed regions
// Treats enemy-held regions as hard blockers
```

**Key Differences from Army Pathfinding:**

| Aspect | Army Movement | Discontiguity Check |
|--------|----------------|---------------------|
| **Purpose** | Find all reachable regions | Find all contiguous with capital |
| **Start Point** | Current army position | Nation capital |
| **Traversal** | Own + Allied + Enemy regions | Own regions ONLY |
| **Blocker Type** | Only enemy (in war) | Any non-owned nation |
| **Adjacency** | Context-dependent | Always `IsAdjacent(..., false)` |
| **Caching** | Yes (frame/7-day) | No (calculated on demand) |
| **Bidirectional** | Yes (optimization) | No (only forward BFS) |

---

## 3. Can Vanilla Code Simplify Discontiguity?

### Option A: Leverage `IsAdjacent()` (Current Approach) ✅
**Status:** Already using vanilla logic
```csharp
potentialNeighbor.IsAdjacent(current, false)
```
- Simple wrapper around region adjacency dictionary
- Fast O(1) lookup

### Option B: Use Army `CanGetTo()` for Contiguity ❌
**Not Recommended:**
- **Overkill complexity:** Bidirectional BFS adds no value for single-source contiguity
- **Wrong enterable regions:** Army uses `CanEnter()` which includes allies/enemies
- **Performance:** Would compute more than needed
- **Coupling:** Ties civilian calculations to military logic

```csharp
// BAD - Don't do this:
var tempArmy = GetFakeNonNavalArmy(nation);
var reachable = tempArmy.ReachableRegions;
// Issues: needs fake army, includes ally/enemy regions, slower
```

### Option C: Use Army's Adjacency Logic Directly ✅
**Already optimal:**
```csharp
// Your current code does this
if (!potentialNeighbor.IsAdjacent(current, false))
	continue;
```
- Direct use of vanilla's adjacency system
- Clean and efficient

---

## 4. Performance Optimization Opportunities

### For Your Discontiguity Calculation:

#### Current Implementation Issues:
```csharp
TIRegionState[] allRegions = GameStateManager.AllRegions();  // Gets ALL regions
foreach (TIRegionState potentialNeighbor in allRegions)      // Iterates every call
```

**Problem:** Checking all ~1000+ regions every time, even though most aren't neighbors

#### Recommended Optimization:
```csharp
// Use vanilla's neighbor dictionary approach
foreach (TIRegionState neighbor in current.Neighbors)  // Only actual neighbors!
{
	if (neighbor == null || contiguousRegions.Contains(neighbor))
		continue;

	if (neighbor.nation != null && neighbor.nation != nation)
		continue;  // Blocked by enemy

	contiguousRegions.Add(neighbor);
	queue.Enqueue(neighbor);
}
```

**Benefits:**
- O(k) per region where k = adjacent regions (~3-6)
- vs O(n) where n = total regions (~1000+)
- **~150-300x faster per region**

---

## 5. Architectural Alignment

### Why NOT Leverage Army Movement Directly:

1. **Separation of Concerns**
   - Army pathfinding = Military logic (considers enemies, allies, wars)
   - Nation contiguity = Governance logic (structural integrity)

2. **Different Problem Domains**
   - Army: "Can this military unit reach there?"
   - Discontiguity: "Is this region structurally connected?"

3. **Unnecessary Overhead**
   - Army caching (frame/7-day) not relevant to cohesion calc
   - Bidirectional search wastes resources for single-source problem

### What CAN be Leveraged:

| Vanilla Component | Your Usage | Benefit |
|------------------|-----------|---------|
| `IsAdjacent(region, false)` | Contiguity check | ✅ Using it |
| `Neighbors` property | Adjacency iteration | ✅ **Consider adopting** |
| Adjacency dictionary | Fast lookups | ✅ Using via `IsAdjacent()` |

---

## 6. Simplified Code Recommendation

### Replace:
```csharp
TIRegionState[] allRegions = GameStateManager.AllRegions();
foreach (TIRegionState potentialNeighbor in allRegions)
{
	if (potentialNeighbor == null || contiguousRegions.Contains(potentialNeighbor))
		continue;
	if (!potentialNeighbor.IsAdjacent(current, false))
		continue;
	if (potentialNeighbor.nation != null && potentialNeighbor.nation != nation)
		continue;

	contiguousRegions.Add(potentialNeighbor);
	queue.Enqueue(potentialNeighbor);
}
```

### With:
```csharp
foreach (TIRegionState neighbor in current.Neighbors)
{
	if (neighbor == null || contiguousRegions.Contains(neighbor))
		continue;

	// Only non-full-adjacency regions can be crossed
	if (neighbor.IsAdjacent(current, false))  // false = non-invading = peaceful
	{
		if (neighbor.nation == null || neighbor.nation == nation)
		{
			contiguousRegions.Add(neighbor);
			queue.Enqueue(neighbor);
		}
	}
}
```

**Rationale:**
- `current.Neighbors` already filters to actual adjacencies
- The `IsAdjacent()` call now serves as explicit validation of traversability
- Clearer intent: "only cross if it's an allowed adjacency type"

---

## 7. Military vs Civilian Contiguity

### Army Movement (Military)
```
Can reach if: owns OR allied OR at war + can pass through
Represents: Military logistics and supply lines
```

### Nation Contiguity (Civilian)
```
Can traverse if: owns OR unclaimed + friendly adjacency
Represents: Infrastructure, governance connectivity, cultural continuity
```

**These are fundamentally different concepts** that happen to share adjacency primitives.

---

## Conclusion

✅ **Use vanilla adjacency primitives** (`IsAdjacent`, `Neighbors`, adjacency dictionary)

❌ **Don't use army movement code** directly - it's solving a different problem

🚀 **Optimize** by using `current.Neighbors` instead of `GameStateManager.AllRegions()`

The vanilla code can simplify discontiguity calculations **at the primitive level** (adjacency checking), but not at the algorithmic level. Your current approach is sound; focus on the iteration optimization for 150-300x performance gain.
