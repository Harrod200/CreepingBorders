# Contiguity Bug Fix - Critical Adjacent Check Error

## Bug Summary
**Severity:** Critical  
**Location:** `CreepingBordersCls.cs`, line 327, in `GetTrueContiguousRegions()` method  
**Issue:** Regions check if they're adjacent to themselves instead of to the current region in BFS traversal  
**Result:** Directly adjacent regions incorrectly show as partially/fully discontiguous (example: Juba and Addis Ababa)

---

## The Bug

### Buggy Code (Line 327)
```csharp
if (!neighbor.IsAdjacent(neighbor, false))  // ❌ WRONG: neighbor checking itself!
	continue;
```

### Problem Explanation
- The BFS traversal examines each region's neighbors
- For each `neighbor`, it needs to check if the neighbor is **adjacent to the current region**
- Instead, the code was checking if the neighbor is **adjacent to itself**
- A region cannot be adjacent to itself, so `IsAdjacent(neighbor, false)` almost always returns false
- This causes the BFS to reject valid neighbors and mark them as discontiguous

---

## The Fix

### Corrected Code (Line 327)
```csharp
if (!neighbor.IsAdjacent(current, false))  // ✅ CORRECT: neighbor adjacent to current
	continue;
```

### How It Works
1. `current` = the region we're examining (from BFS queue)
2. `neighbor` = a candidate adjacent region from current's neighbor list
3. `neighbor.IsAdjacent(current, false)` = check if neighbor is adjacent to current
   - First parameter: the region to check adjacency WITH (current)
   - Second parameter: false = not treating as an invasion, so normal adjacency applies
4. If the check passes, the neighbor is added to the contiguous set and queued for further traversal

---

## Impact Analysis

### Affected Functionality
- ✅ **GetTrueContiguousRegions()** - Core contiguity calculation
- ✅ **IsFullyDiscontiguous()** - Depends on correct contiguity detection
- ✅ **IsPartiallyDiscontiguous()** - Depends on correct contiguity detection
- ✅ **GetContiguityStatus()** - Returns wrong status for adjacent regions
- ✅ **BuildRegionDataTooltip()** - Displays incorrect contiguity info in UI
- ✅ **GetDiscontiguityImpactOnCohesion()** - Incorrectly calculates discontiguity penalties
- ✅ **Contiguity highlighting** - Shows wrong colors (orange/yellow instead of correct)

### Example Scenario
**Before Fix:**
- Juba and Addis Ababa owned by same nation
- Directly adjacent to each other
- Bug: Neither finds the other as adjacent during BFS
- Result: Both marked as fully/partially discontiguous ❌

**After Fix:**
- Juba and Addis Ababa owned by same nation
- Directly adjacent to each other
- Fix: Both find each other as adjacent during BFS
- Result: Both correctly marked as contiguous ✅

---

## Technical Details

### BFS Traversal Logic
The algorithm uses Breadth-First Search to find all regions contiguous with the capital:

```
1. Start: Add capital to contiguous set, queue it
2. Loop: While queue not empty:
   a. Dequeue current region
   b. For each neighbor in current's neighbors:
	  i.   Skip if neighbor already in contiguous set
	  ii.  Skip if neighbor NOT adjacent to current ← FIX APPLIED HERE
	  iii. Skip if neighbor owned by different nation
	  iv.  Add neighbor to contiguous set, queue it
```

The bug was in step 2.b.ii - it was checking the wrong adjacency pair.

### IsAdjacent Method Signature
```csharp
public bool IsAdjacent(TIRegionState region, bool IAmAnInvadingArmy)
```
- **region** parameter: The region to check adjacency WITH
- **IAmAnInvadingArmy** parameter: false for normal traversal, true if in invasion context
- Returns: true if regions are adjacent (either full adjacency or friendly crossing)

### Why Self-Adjacency Always Fails
In Terra Invicta's region system, a region cannot be adjacent to itself:
- `region.IsAdjacent(region, false)` always returns false
- This is why the bug broke the entire BFS traversal

---

## Testing Recommendations

### Manual Test Cases

#### Test 1: Direct Adjacent Regions
1. Load a game where a nation owns two directly adjacent regions
2. Enable debug logging
3. Check the logs - should show both regions as contiguous
4. Hover over each region in UI - should display "Contiguous"
5. Neither should have orange/yellow highlighting

**Example:** Juba (E Africa) adjacent to Addis Ababa (E Africa)

#### Test 2: Chain of Regions
1. Create a nation with a chain: Region A → B → C
2. Region A is capital
3. All three should show as contiguous
4. Logs should show all three in one contiguous set

#### Test 3: Separated by Enemy Territory
1. Create a nation with regions A and B
2. Separate them with an enemy-owned region C
3. Region B should show as discontiguous
4. B should NOT be in the contiguous set returned by GetTrueContiguousRegions()

#### Test 4: Discontiguity Malus Calculation
1. Enable DiscontiguityMalus in settings
2. Create nation with discontiguous regions
3. Check cohesion calculation - should apply appropriate penalty
4. Debug log should show region lists clearly

---

## Code Review Checklist

- ✅ Bug identified and corrected
- ✅ Parameter order verified
- ✅ No compilation errors
- ✅ Build successful
- ✅ Related methods verified (no similar bugs found)
- ✅ Logic verified against BFS algorithm

---

## Verification

### Build Status
✅ **Successful** - Project builds with no errors

### Files Modified
- `CreepingBordersCls.cs` - Line 327 fixed

### Commit Message (Suggested)
```
Fix critical contiguity bug: correct IsAdjacent parameter in BFS traversal

GetTrueContiguousRegions was checking neighbor.IsAdjacent(neighbor, false)
instead of neighbor.IsAdjacent(current, false), causing the algorithm to
reject all neighbors and incorrectly mark adjacent regions as discontiguous.

This fixes the issue where Juba and Addis Ababa show as partially discontiguous
despite being directly adjacent and owned by the same nation.

Fixes #[issue_number]
```

---

## Related Code Areas

### Methods That Depend on This Fix
1. **GetDiscontiguityInfo()** (line 458) - Uses GetTrueContiguousRegions() to determine discontiguity status
2. **IsFullyDiscontiguous()** (line 520) - Extension method
3. **IsPartiallyDiscontiguous()** (line 535) - Extension method
4. **GetContiguityStatus()** (line 557) - Returns localized string
5. **BuildRegionDataTooltip()** (line 1281) - Uses GetContiguityStatus() for display

### Localization Keys Affected
- `UI.Nation.Contiguity.Contiguous` - Should now display correctly for adjacent regions
- `UI.Nation.Contiguity.FullyDiscontiguous` - Should only appear for actually discontiguous regions
- `UI.Nation.Contiguity.PartiallyDiscontiguous` - Should only appear for ally-bridged regions

---

## Performance Note

This fix has **NO negative performance impact**:
- The BFS algorithm is already O(n) where n = number of regions
- Fixing the adjacency check doesn't change algorithm complexity
- If anything, it may improve performance by correctly terminating regions as contiguous sooner

---

## Root Cause Analysis

This bug likely resulted from:
1. Copy-paste error during development
2. Unclear parameter naming (both "neighbor" and "current" could refer to different things)
3. Insufficient testing with directly adjacent regions
4. The bug was silent - no exceptions thrown, just wrong results

### Prevention Strategy
- Add unit tests for contiguity calculation with known adjacency patterns
- Use parameter names like `checkAgainstRegion` instead of just reusing variable names
- Add logging to verify BFS traversal (already implemented in recent commits)
