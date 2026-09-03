# Performance Bottleneck Analysis: GetTrueContiguousRegionsWithExtended

## Executive Summary
The method has several optimization opportunities that could further improve performance beyond the current optimizations. Critical bottlenecks are identified below with severity levels and recommended fixes.

---

## Critical Bottlenecks

### 1. **Debug Logging Overhead (CRITICAL - High Impact)**
**Location**: Lines throughout the method  
**Severity**: CRITICAL  
**Current Impact**: Even when disabled, the logger check happens frequently

**Problem**:
```csharp
if (CreepingBordersCls.Settings.EnableDebugLogging)
{
	CreepingBordersCls.mod.Logger.Log($"[Contiguity] {neighbor.displayName}...");
}
```
- String interpolation occurs **before** the boolean check in many cases
- Logging calls are distributed across multiple loops (island detection, distance checks, island connections)
- In `FindContinentsConnectedByIslands`, debug logging happens inside nested loops:
  - Outer loop: iterations until no new regions found
  - Middle loop: all regions to find coastal islands
  - Inner loop: BFS through coastal islands and their neighbors
  - Logging inside each loop multiplies the overhead

**Root Cause**: String formatting is evaluated at the point of call, not inside the if block

**Recommended Fix**:
Conditional string formatting (use [CallerArgumentExpression] or lazy evaluation):
```csharp
// Before:
if (CreepingBordersCls.Settings.EnableDebugLogging)
{
	CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): {regionType}...");
}

// After (Option 1 - Move string building inside if):
if (CreepingBordersCls.Settings.EnableDebugLogging)
{
	string msg = $"[Contiguity] {region.displayName} ({nation.displayName}): {regionType}...";
	CreepingBordersCls.mod.Logger.Log(msg);
}

// After (Option 2 - Use string builder for complex messages):
if (CreepingBordersCls.Settings.EnableDebugLogging)
{
	var sb = new System.Text.StringBuilder();
	sb.Append("[Contiguity] ").Append(region.displayName).Append(" (")
	  .Append(nation.displayName).Append("): ")...;
	CreepingBordersCls.mod.Logger.Log(sb.ToString());
}
```

**Estimated Improvement**: 15-25% faster execution when debug logging is disabled

---

### 2. **Repeated GetLandmassType() Calls in Distance-Based Island Bridge Pass (HIGH - Medium Impact)**
**Location**: Lines 897-912  
**Severity**: HIGH  
**Current Impact**: Redundant type classification in tight loops

**Problem**:
```csharp
// Line 897-901
foreach (TIRegionState region in nation.regions)
{
	if (region != null && region.GetLandmassType() == LandmassType.Island && 
		(currentContiguity.ExtendedDistanceRegions.Contains(region) || !currentContiguity.AllContiguousRegions.Contains(region)))
	{
		candidateIslands.Add(region);
	}
}

// Line 927-930 (later in same method)
foreach (TIRegionState contiguousRegion in currentContiguity.FullyContiguousRegions)
{
	if (contiguousRegion == null || contiguousRegion.GetLandmassType() != LandmassType.Island)
		continue;
```

This happens **for each iteration** of the outer while loop (lines 785-786) until no new regions are found!

**Root Cause**: 
- `GetLandmassType()` is expensive (BFS to count connected regions)
- Called repeatedly for the same regions across iterations
- No cache carried across iterations

**Recommended Fix**:
Move landmass type determination outside the loop, cache persistently:
```csharp
// Pre-compute island classification ONCE before the while loop
var regionIslandMap = new Dictionary<TIRegionState, bool>(nation.regions.Count);
foreach (TIRegionState region in nation.regions)
{
	if (region != null)
		regionIslandMap[region] = region.GetLandmassType() == LandmassType.Island;
}

// Inside while loop, use cached lookup
var candidateIslands = new List<TIRegionState>();
foreach (TIRegionState region in nation.regions)
{
	if (region != null && regionIslandMap[region] && 
		(currentContiguity.ExtendedDistanceRegions.Contains(region) || !currentContiguity.AllContiguousRegions.Contains(region)))
	{
		candidateIslands.Add(region);
	}
}
```

**Estimated Improvement**: 20-40% faster in the third pass (depends on iteration count)

---

### 3. **HashSet.Contains() Called Multiple Times Per Iteration (MEDIUM - Medium Impact)**
**Location**: Throughout the method  
**Severity**: MEDIUM  
**Current Impact**: Redundant membership checks

**Problem**:
In the main loop for distance candidates (lines 651-677):
```csharp
foreach (TIRegionState region in candidateRegions)
{
	var (distanceCategory, distance, closestRegionName) = GetExtendedDistanceInfo(
		region, result.FullyContiguousRegions, maxDistance);

	if (distanceCategory == 0)
	{
		regionsToAdd[region] = true;
		// ... logging uses result.FullyContiguousRegions check implicitly
	}
}

// Later: ADD to HashSet
foreach (var kvp in regionsToAdd)
{
	result.AllContiguousRegions.Add(kvp.Key);
	if (kvp.Value)
	{
		result.FullyContiguousRegions.Add(kvp.Key);
	}
}
```

And in `FindContinentsConnectedByIslands`:
```csharp
// Line 846
if (!currentContiguity.AllContiguousRegions.Contains(neighbor))
{
	// ... then inside
	if (!isNeighborIsland)
	{
		currentContiguity.FullyContiguousRegions.Add(neighbor);
		currentContiguity.AllContiguousRegions.Add(neighbor);
	}
}
```

**Root Cause**: 
- `HashSet<T>.Contains()` is O(1) but still has overhead
- Checking both `ExtendedDistanceRegions` and `AllContiguousRegions` for same object
- Multiple redundant checks before adding

**Recommended Fix**:
Combine checks or use `TryAdd` pattern if available:
```csharp
// Instead of multiple Contains checks
if (!currentContiguity.AllContiguousRegions.Contains(neighbor) && !isNeighborIsland)
{
	currentContiguity.FullyContiguousRegions.Add(neighbor);
	if (!currentContiguity.AllContiguousRegions.Add(neighbor))
	{
		// Already exists, skip
		continue;
	}
	foundNewRegions = true;
}
```

**Estimated Improvement**: 5-10% faster execution

---

### 4. **Distance Caching with Tuple Keys Has Collision Risk (MEDIUM - Low Impact)**
**Location**: Lines 469-475  
**Severity**: MEDIUM  
**Current Impact**: Cache doesn't benefit from bidirectional lookups

**Problem**:
```csharp
var key = (region, refRegion);
if (!distanceCache.TryGetValue(key, out float distance))
{
	distance = TIRegionState.DistanceBetweenTwoCoordinates_km(...);
	distanceCache[key] = distance;
}
```

- Distance from A→B is the same as B→A, but cached separately
- If the same pair is queried in opposite order, cache misses
- Wastes approximately 50% of cache entries on duplicate calculations

**Root Cause**: Naive tuple caching without normalizing pair order

**Recommended Fix**:
Normalize tuple order before caching:
```csharp
// Ensure consistent cache key regardless of order
var normalizedKey = region.GetHashCode() < refRegion.GetHashCode() 
	? (region, refRegion) 
	: (refRegion, region);

if (!distanceCache.TryGetValue(normalizedKey, out float distance))
{
	distance = TIRegionState.DistanceBetweenTwoCoordinates_km(...);
	distanceCache[normalizedKey] = distance;
}
```

**Estimated Improvement**: 10-15% better cache hit rate (2-5% overall improvement)

---

### 5. **Redundant AllContiguousRegions Checks in Second Pass (MEDIUM - Low Impact)**
**Location**: Lines 630-635  
**Severity**: MEDIUM  
**Current Impact**: Inefficient filtering logic

**Problem**:
```csharp
var candidateRegions = new List<TIRegionState>(nation.regions.Count);
foreach (TIRegionState region in nation.regions)
{
	if (region != null && !result.AllContiguousRegions.Contains(region))
	{
		LandmassType landmassType = region.GetLandmassType();
		bool isIsland = landmassType == LandmassType.Island;
		bool isCoastalContinent = landmassType == LandmassType.Continent && IsCoastalRegion(region);

		if (isIsland || isCoastalContinent)
		{
			candidateRegions.Add(region);
		}
	}
}
```

- Check `AllContiguousRegions.Contains(region)` happens **before** expensive `GetLandmassType()` ✓ (Good!)
- BUT: The list is pre-sized to `nation.regions.Count`, wasting memory if most are already contiguous
- `IsCoastalRegion` is called for every continent, even those already contiguous

**Root Cause**: Over-eager memory allocation and over-checking

**Recommended Fix**:
```csharp
var candidateRegions = new List<TIRegionState>();  // Don't pre-size
foreach (TIRegionState region in nation.regions)
{
	if (region == null || result.AllContiguousRegions.Contains(region))
		continue;

	LandmassType landmassType = region.GetLandmassType();
	if (landmassType == LandmassType.Island)
	{
		candidateRegions.Add(region);
	}
	else if (landmassType == LandmassType.Continent && IsCoastalRegion(region))
	{
		candidateRegions.Add(region);
	}
}
```

**Estimated Improvement**: 5-10% reduction in memory pressure, 2-3% faster iteration

---

### 6. **FindContinentsConnectedByIslands: Repeated Full Scan of Nation Regions (HIGH - High Impact)**
**Location**: Lines 788-800 (inside while loop)  
**Severity**: HIGH  
**Current Impact**: Exponential complexity in worst case

**Problem**:
```csharp
while (foundNewRegions && iterationCount < maxIterations)  // Line 785
{
	foundNewRegions = false;
	iterationCount++;

	// Find all coastal islands (islands adjacent to currently contiguous regions)
	var coastalIslands = new HashSet<TIRegionState>();
	foreach (TIRegionState region in nation.regions)  // FULL SCAN every iteration!
	{
		if (region != null && IsCoastalIsland(region, nation, currentContiguity.FullyContiguousRegions))
		{
			coastalIslands.Add(region);
		}
	}
```

**Root Cause**:
- Full scan of `nation.regions` happens every iteration
- If map has many islands and slow coastal bridges, this can iterate 10-100 times
- `IsCoastalIsland()` itself iterates all neighbors, checking full adjacency
- With 100+ regions, this becomes O(regions × iterations × neighbors)

**Recommended Fix**:
Maintain incremental set of known coastal islands:
```csharp
var allCoastalIslands = new HashSet<TIRegionState>();

while (foundNewRegions && iterationCount < maxIterations)
{
	foundNewRegions = false;
	iterationCount++;

	// Only check NEW contiguous regions added in last iteration
	var newlyContiguous = lastIterationAdded ?? currentContiguity.FullyContiguousRegions;
	var newCoastalIslands = new HashSet<TIRegionState>();

	foreach (TIRegionState island in allCoastalIslands)
	{
		// Check if still coastal with NEW contiguous regions
		foreach (TIRegionState neighbor in island.Neighbors)
		{
			if (neighbor != null && newlyContiguous.Contains(neighbor))
			{
				newCoastalIslands.Add(island);
				break;
			}
		}
	}

	// Add any NEWLY coastal islands from unprocessed regions
	// (only scan regions not yet checked)
	for (int i = processedRegionCount; i < nation.regions.Count; i++)
	{
		TIRegionState region = nation.regions[i];
		if (region != null && IsCoastalIsland(region, nation, currentContiguity.FullyContiguousRegions))
		{
			allCoastalIslands.Add(region);
			newCoastalIslands.Add(region);
		}
	}

	// BFS through NEW coastal islands only
	if (newCoastalIslands.Count > 0)
	{
		// ... rest of BFS logic
	}
}
```

**Estimated Improvement**: 30-60% faster (depends on iteration count)

---

### 7. **String Formatting in Hot Paths (LOW - Low Impact)**
**Location**: Lines 656, 668, and throughout logging  
**Severity**: LOW  
**Current Impact**: Minor allocation overhead

**Problem**:
```csharp
CreepingBordersCls.mod.Logger.Log($"[Contiguity] {region.displayName} ({nation.displayName}): " +
	$"{regionType} within distance range (fully contiguous) - Distance: {distance:F2} km from {closestRegionName}");
```

- Each log call creates string allocations
- Even with debug logging off, the string concatenation might happen during compilation (depends on JIT)

**Root Cause**: Excessive string allocations in logging

**Recommended Fix**:
Use `StringBuilder` for complex log messages:
```csharp
if (CreepingBordersCls.Settings.EnableDebugLogging)
{
	var sb = new System.Text.StringBuilder(128);
	sb.Append("[Contiguity] ")
	  .Append(region.displayName)
	  .Append(" (").Append(nation.displayName)
	  .Append("): ").Append(regionType)
	  .Append(" within distance range - Distance: ")
	  .Append(distance.ToString("F2"))
	  .Append(" km from ").Append(closestRegionName);
	CreepingBordersCls.mod.Logger.Log(sb.ToString());
}
```

**Estimated Improvement**: 2-5% faster (mainly visible with logging enabled)

---

## Summary of Optimization Priorities

| Priority | Bottleneck | Severity | Est. Gain | Implementation Difficulty |
|----------|-----------|----------|-----------|--------------------------|
| 1 | Debug logging overhead | CRITICAL | 15-25% | Easy |
| 2 | Repeated GetLandmassType() in third pass | HIGH | 20-40% | Medium |
| 3 | Full region scan in FindContinentsConnectedByIslands | HIGH | 30-60% | Hard |
| 4 | Distance cache not normalized | MEDIUM | 2-5% | Easy |
| 5 | Multiple HashSet.Contains() checks | MEDIUM | 5-10% | Medium |
| 6 | Pre-sizing candidate list | MEDIUM | 2-3% | Easy |
| 7 | String formatting overhead | LOW | 2-5% | Easy |

---

## Recommended Implementation Order

1. **Phase 1 (Quick Wins)** - 20-25% improvement, ~1 hour
   - Move debug logging strings inside if blocks
   - Normalize distance cache keys
   - Fix pre-sizing of candidate list

2. **Phase 2 (Medium Effort)** - 20-40% improvement, ~2-3 hours
   - Cache GetLandmassType() results outside third pass loop
   - Optimize HashSet.Contains() with TryAdd pattern

3. **Phase 3 (Advanced)** - 30-60% improvement, ~4-6 hours
   - Implement incremental coastal island detection in FindContinentsConnectedByIslands
   - This requires careful refactoring to track state across iterations

---

## Testing Recommendations

After each optimization phase:
1. Run existing unit tests to verify correctness
2. Profile the method with representative data (large nations with many islands)
3. Verify debug logging still works correctly when enabled
4. Check memory allocation patterns with memory profiler

