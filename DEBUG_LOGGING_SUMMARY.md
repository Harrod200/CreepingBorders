# Contiguity Debug Logging Summary

## Overview
Added comprehensive debug toggle-controlled logging to the contiguity system. All logging is controlled by the `EnableDebugLogging` setting in mod settings and uses the standard `[Contiguity]` prefix for easy filtering.

## Logging Points

### 1. GetDiscontiguityInfo Method (Core Detection)
**File:** CreepingBordersCls.cs, lines ~458-510

**Log Entries:**
- **Contiguous regions:** `[Contiguity] {region} ({nation}): Contiguous (part of main landmass)`
- **Fully discontiguous:** `[Contiguity] {region} ({nation}): FULLY DISCONTIGUOUS - not reachable through allied territory`
- **Partially discontiguous:** `[Contiguity] {region} ({nation}): PARTIALLY DISCONTIGUOUS - reachable through allied territory`

**When logged:** Every time a region's discontiguity status is checked (cached results included)

---

### 2. GetAllyReachableDiscontiguousRegions Method (Ally Bridge Analysis)
**File:** CreepingBordersCls.cs, lines ~575-665

**Log Entries:**
- **No allies available:** `[Contiguity] {nation}: No allies to bridge discontiguous regions. Discontiguous count: {count}`
- **Analysis start:** `[Contiguity] {nation}: Checking ally reachability. Discontiguous regions: {count}, Traversable regions: {total} (own: {ownCount}, allied: {alliedCount})`
- **Per-region discovery:** `[Contiguity]   └─ {region} is ally-reachable via {bridge_region}`
- **Summary:** `[Contiguity] {nation}: Found {count} ally-reachable discontiguous regions`

**When logged:** When ally reachability is analyzed, showing progression through BFS discovery

---

### 3. IsFullyDiscontiguous Extension Method (Property Check)
**File:** CreepingBordersCls.cs, lines ~520-533

**Log Entry:**
- `[Contiguity] IsFullyDiscontiguous check: {region} = True`

**When logged:** Only when the check returns `true` (to avoid log spam on contiguous regions)

---

### 4. IsPartiallyDiscontiguous Extension Method (Property Check)
**File:** CreepingBordersCls.cs, lines ~535-548

**Log Entry:**
- `[Contiguity] IsPartiallyDiscontiguous check: {region} = True`

**When logged:** Only when the check returns `true` (to avoid log spam on contiguous regions)

---

### 5. GetDiscontiguityImpactOnCohesion Method (Bulk Calculation)
**File:** CreepingBordersCls.cs, lines ~1090-1190

**Log Output (Multi-line):**
```
[Discontiguity] {nation} Cohesion Impact Calculation:
  Total Discontiguous Population: {population:N0}
  Fully Discontiguous ({count} regions, {population:N0} pop):
	- {region_name}
	- {region_name}
	Full Penalty: {penalty:N2}
  Partially Discontiguous ({count} regions, {population:N0} pop):
	- {region_name}
	- {region_name}
	Half Penalty: {penalty:N2}
  Total Penalty (clamped): {total_penalty:N2}
```

**When logged:** When cohesion impact is calculated for a nation with discontiguous regions

---

## Log Output Organization

All logs use consistent prefixes:
- `[Contiguity]` - Main discontiguity analysis and detection
- `[Discontiguity]` - Cohesion malus calculation and impact

This allows filtering in the mod manager's log viewer with searches like:
- `[Contiguity]` - See all contiguity checks and ally reachability analysis
- `[Discontiguity]` - See only cohesion malus calculations
- `FULLY DISCONTIGUOUS` - Find all fully discontiguous region detections
- `PARTIALLY DISCONTIGUOUS` - Find all partially discontiguous region detections

## Performance Notes

**Logging overhead:**
- Only logs when `EnableDebugLogging` is true (setting check is very fast)
- Property check logs only on `true` results (not on contiguous regions)
- BFS traversal logs are inside the detailed analysis (already running)
- Bulk calculation logs are part of the cohesion calculation (already running every phase)

**Expected log volume:**
- Small to medium game: 0-5 contiguity checks per phase (only on discontiguous regions)
- Large game: 5-20 entries per phase depending on number of discontiguous nations
- Cohesion calculation logs: 1-5 entries per nation per phase (only if they have discontiguous regions)

## Testing the Logging

### Recommended Test Scenarios:

1. **Simple Discontiguity:**
   - Use a nation with an island territory
   - Look for: `FULLY DISCONTIGUOUS` and `PARTIALLY DISCONTIGUOUS` entries for each island

2. **Ally-Bridged Territories:**
   - Create alliance with territory between your discontiguous regions
   - Look for: `is ally-reachable via` entries showing the bridge path

3. **Cohesion Impact:**
   - Enable `EnableDiscontiguityMalus` setting
   - Look for: Structured bulk log showing population breakdown and penalty calculation

4. **Large Nations:**
   - Play a game with sprawling borders
   - Monitor log volume to ensure no performance impact

## Implementation Details

- Helper method `FormatRegionNationInfo()` ensures consistent formatting
- StringBuilder used for multi-line logs to avoid excessive string concatenation
- All logging checks wrapped in `if (CreepingBordersCls.Settings.EnableDebugLogging)` guards
- No changes to non-logging logic - purely additive instrumentation
