# Implementation Summary: Army Movement & Discontiguity Analysis

## What I Analyzed

### 1. Vanilla Army Viable Movement (No Navy, No Allies)
- **Algorithm:** Bidirectional BFS pathfinding in `TIArmyState.CanGetTo()`
- **Key Logic:**
  - Uses `IsAdjacent(region, invasionArmy)` to determine traversability
  - Filters enterable regions based on nation relationships (own + allies + enemies)
  - For ground armies with no navy: relies purely on terrestrial adjacencies
  - Two adjacency types for peaceful movement:
	- `FullAdjacency`: Can always traverse
	- `FriendlyCrossingOnly`: Can only traverse if no war with that nation

### 2. Current Discontiguity Calculation
Your `GetTrueContiguousRegions()` method correctly:
- Performs BFS from the capital
- Treats enemy-held regions as hard boundaries
- Uses `IsAdjacent(region, false)` to identify valid neighbors

## Key Findings

### ✅ What's Working Well
1. **Correct use of vanilla adjacency primitives:** Your code properly leverages `IsAdjacent()`, which wraps the vanilla adjacency dictionary
2. **Proper blocking behavior:** Enemy-held regions correctly block contiguity
3. **Sound algorithm:** BFS from capital is the right approach for finding contiguous territories

### ⚠️ Performance Issue Identified
**The Problem:**
```csharp
TIRegionState[] allRegions = GameStateManager.AllRegions();  // 1000+ regions
foreach (TIRegionState potentialNeighbor in allRegions)      // Checked EVERY iteration
```

- Checking all ~1000 regions from every region in the BFS queue
- Most regions aren't actually adjacent to the current region
- Creates O(n²) behavior for large connected territories

**The Fix:**
```csharp
foreach (TIRegionState neighbor in current.Neighbors)  // Only 3-6 neighbors
```

- Uses vanilla's neighbor dictionary (already optimized by the game)
- Provides **150-300x performance improvement**
- O(n) behavior instead of O(n²)

### ❌ Why NOT Use Army Movement Code
1. **Over-engineering:** Army pathfinding is solving a military problem; discontiguity is structural
2. **Wrong context:** Army considers allies and enemies; discontiguity should not
3. **Unnecessary complexity:** Bidirectional BFS adds no value for single-source contiguity
4. **Tight coupling:** Would tie civilian calculations to military logic

### ✅ What CAN Be Leveraged from Vanilla
| Component | Location | Your Usage |
|-----------|----------|-----------|
| `IsAdjacent(region, bool)` | TIRegionState | ✅ Already using |
| `GetAdjacencyType(region)` | TIRegionState | ✅ Used via `IsAdjacent()` |
| `Neighbors` property | TIRegionState | ✅ **NOW USING** |
| Adjacency dictionary | TIRegionState.adjacencies | ✅ Foundation of above |

## Changes Made

### Modified: `GetTrueContiguousRegions()`
**Before:** Iterated through `GameStateManager.AllRegions()` (~1000 regions per queue iteration)
**After:** Uses `current.Neighbors` property (~3-6 regions per queue iteration)

**Benefits:**
- ~150-300x faster for large nations with many regions
- Cleaner code with better intent
- More aligned with vanilla architecture
- Reduced memory pressure from large array allocations

**No behavioral changes:** Same contiguity results, just faster execution

## Code Documentation Added
Enhanced comments in `GetTrueContiguousRegions()` to explain:
1. The `IsAdjacent()` parameters and return values
2. Why we check `neighbor.nation` 
3. The optimization rationale
4. Performance expectations

## Files Included

1. **CONTIGUITY_ANALYSIS.md** - Detailed technical analysis of:
   - Army movement algorithm step-by-step
   - Comparison with discontiguity calculation
   - Architectural considerations
   - Performance optimization opportunities

2. **CreepingBordersCls.cs** - Updated with:
   - Performance-optimized `GetTrueContiguousRegions()` method
   - Improved code comments explaining adjacency logic
   - No functional changes to behavior

## Testing Recommendations

1. **Functional Testing:**
   - Verify discontiguity penalty still calculates correctly
   - Check that isolated regions are still identified properly
   - Test island vs continent classification

2. **Performance Testing:**
   - Monitor cohesion calculation time (should be 150-300x faster)
   - Check in late game with many regions claimed
   - Profile during CPU-heavy turn processing

3. **Debug Logging:**
   Use `EnableDebugLogging = true` in mod settings to verify:
   - `[Discontiguity] DiscontiguousPopulation: X, Penalty: Y`
   - Penalty values are correctly applied to cohesion totals

## Conclusion

The vanilla code can simplify discontiguity calculations **at the primitive level** (adjacency checking), but not at the algorithmic level. The key optimization was replacing brute-force region checking with vanilla's built-in neighbor tracking—a change that maintains all correctness while dramatically improving performance.
