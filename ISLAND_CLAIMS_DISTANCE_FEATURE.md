# Island Claims Within Distance Feature

## Overview
A new UMM settings option has been added that allows nations to automatically claim all island regions within a specified distance threshold when they border adjacent enemy regions.

## Settings

### New Settings Properties
```csharp
public bool ClaimIslandsWithinDistance = false;      // Toggle to enable/disable
public float ClaimIslandsDistanceKM = 3000f;         // Distance threshold in KM
```

### UI Configuration
- **Toggle Label**: "Claim Islands Within Distance"
- **Description**: "Claim all island regions of neighboring nations within the distance threshold (in KM)"
- **Slider Label**: "Island Claim Distance"
- **Range**: 1,000 - 10,000 KM
- **Default**: 3,000 KM
- **Position**: Between "Claim Islands on Capital Contact" and "No Distance Cohesion Malus"

---

## How It Works

### Activation Criteria
When a nation borders an adjacent region (normal border expansion):

1. **For each neighboring region** in that nation:
   - Check if the neighboring region belongs to another nation
   - If enabled: `ClaimIslandsWithinDistance == true`

2. **For each island region** belonging to the neighboring nation:
   - Calculate distance using **great circle formula** (same as cohesion distance)
   - Distance formula: `TIRegionState.DistanceBetweenTwoCoordinates_km(lat1, lon1, lat2, lon2, planetRadius)`

3. **If distance ≤ threshold**:
   - Find all contiguous regions on that island (full adjacency)
   - Add claims for ALL regions on the island
   - Each region only added once (duplicate check)

### Logic Flow
```
Nation A borders Region B (of Nation B)
	↓
For each island region in Nation B:
	- Calculate distance: Region A → Island Region
	- If distance ≤ 3000 KM:
		- Get all contiguous regions on that island
		- Add claims to entire island
	- If distance > 3000 KM:
		- Skip this island
```

---

## Example Scenarios

### Scenario 1: Default Settings (3000 KM)
- Nation A borders Nation B's continent
- Nation B has island chains at various distances:
  - Island 1: 2500 KM away → **Claimed**
  - Island 2: 4200 KM away → **Not claimed**
  - Island 3: 1800 KM away → **Claimed**

### Scenario 2: Aggressive Settings (8000 KM)
- Nation A borders Nation B's continent
- Claims all islands within 8000 KM
- Enables rapid long-distance island strategies

### Scenario 3: Conservative Settings (1000 KM)
- Nation A borders Nation B's continent
- Only claims very nearby islands
- Requires careful positioning for island conquest

---

## Distance Calculation
Uses the **Haversine formula** (great circle distance):

```csharp
float distanceKM = TIRegionState.DistanceBetweenTwoCoordinates_km(
	region1.latitude,              // Bordered region latitude
	region1.longitude,             // Bordered region longitude
	potentialIslandRegion.latitude,   // Target island region latitude
	potentialIslandRegion.longitude,  // Target island region longitude
	region1.ref_spaceBody.meanRadius_km  // Planet radius
);
```

**Same calculation method** used for:
- Cohesion distance penalties (`distanceFromCapitalToPopCenter_km`)
- Other distance-based game mechanics

---

## Island Detection
An island is defined as any landmass with **fewer than 5 contiguous regions** (using full adjacency).

When a single island region meets the distance criteria, **all regions connected to it** are claimed automatically.

---

## Feature Combination
This feature works alongside:

1. **Border Expansion** (`EnableBorderExpansion`)
   - Required: Must have border expansion enabled
   - Triggered on: Region control changes

2. **Capital Contact Islands** (`ClaimIslandsOnCapitalContact`)
   - Independent feature
   - Doesn't overlap (different triggers)
   - Can both be enabled simultaneously

3. **No Hostile Claims** (`NoHostileClaims`)
   - Post-processes all claims
   - Converts hostile to friendly

---

## Performance Notes
- **Efficiency**: Only calculates for islands (< 5 regions)
- **Early exit**: Skips islands already claimed
- **Hash set**: Prevents duplicate additions
- **Recursive**: Uses full adjacency to find all island regions
- **Minimal overhead**: Only runs on border changes

---

## Configuration Examples

### Realistic Island Conquest
```
ClaimIslandsWithinDistance = true
ClaimIslandsDistanceKM = 2000   // Nearby islands only
```
Encourages strategic positioning before island claims.

### Aggressive Expansion
```
ClaimIslandsWithinDistance = true
ClaimIslandsDistanceKM = 8000   // Far-reaching claims
```
Enables rapid domination of entire archipelagos.

### Hybrid Approach
```
ClaimIslandsOnCapitalContact = true    // Capital contact
ClaimIslandsWithinDistance = true       // + Distance-based
ClaimIslandsDistanceKM = 5000
```
Combines both strategies for maximum island coverage.

---

## Implementation Details

### Helper Method
```csharp
private static void GetAllRegionsOnIsland(
	TIRegionState startRegion, 
	HashSet<TIRegionState> visitedRegions)
```
- Recursively finds all contiguous regions on an island
- Uses full adjacency (`IsAdjacent(neighbor, true)`)
- Prevents infinite loops with HashSet tracking

### Integration Point
- **Patch**: `RegionControlChangedPatch`
- **Trigger**: Region control changes
- **Timing**: After normal border expansion
- **Safe**: Checks for null nations and existing claims

