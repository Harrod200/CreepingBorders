# Army Movement System: Navy Embarkation Rules

## Overview
The army movement system decides whether armies with a navy can embark from/to a region based on **adjacency checks** and **sea travel route calculations**. The system prevents armies from directly moving between non-adjacent regions and instead forces them into a multi-stage sea transit operation.

---

## Key Decision Points

### 1. **Adjacency Check** (Initial Gate)
When an army is given a **DeployArmyOperation** order:

```csharp
if (operationData.operation.GetTemplate() is DeployArmyOperation &&
	operationData.target != this.currentRegion &&
	!operationData.target.ref_region.AdjacentRegions(true).Contains(this.currentRegion) &&
	this.embarkDate != null && this.destinationSeaDate != null)
```

**Location:** `TIArmyState.cs` (line 1778)

**Logic:**
1. If target region **IS adjacent** → Direct land movement (no navy needed)
2. If target region **IS NOT adjacent** → Trigger sea transit stages

The adjacency check uses `AdjacentRegions(true)` where `true` means "only show friendly/passable adjacencies" (respects war status).

---

### 2. **Sea Transit Stages**
When sea transit is triggered, three time-based stages are created:

```csharp
public void SetSeaTransitStages(TIDateTime startDate, TIDateTime completionDate, TIRegionState destinationRegion)
{
	double num = completionDate.DifferenceInSeconds(startDate);

	// Stage 1: Embarking (0-33% of transit time)
	this.embarkDate = new TIDateTime(startDate);
	this.embarkDate.AddSeconds(num * 0.33);  // 33% of total time

	// Stage 2: In Transit (33%-67% of transit time)
	this.destinationSeaDate = new TIDateTime(startDate);
	this.destinationSeaDate.AddSeconds(num * 0.67);  // 67% of total time

	// Create time events for each stage
	TITimeEvent.CreateNewTimeEvent(this.embarkDate, ..., this.currentRegion.ArmyEmbarkEventName, ...);
	TITimeEvent.CreateNewTimeEvent(this.destinationSeaDate, ..., destinationRegion.ArmySeaTransitEventName, ...);
}
```

**Location:** `TIArmyState.cs` (line 1748)

**Three Stages:**
1. **Embarking** (0-33%): Army is at origin, loading onto ships
2. **Sea_HomeRegion** (33-67%): Army is in transit in home waters
3. **Sea_DestinationRegion** (67-100%): Army is in transit near destination, can be intercepted

---

### 3. **Coastal Check** (Pre-Embarkation Requirement)
For embarkation to be possible, regions must be **coastal**:

```csharp
public bool isCoastal
{
	get
	{
		return this.oceanType == WorldOceanType.Yes || 
			   this.oceanType == WorldOceanType.Seasonal;
	}
}
```

**Location:** `TIRegionState.cs` (line 604)

**Coastal Requirements:**
- **YES**: Permanently coastal year-round
- **Seasonal**: Coastal during certain months (based on latitude)
  - Northern hemisphere: Months 4-9 (April-September)
  - Southern hemisphere: Months 1-3, 10-12 (Jan-Mar, Oct-Dec)
- **NO**: Not coastal, cannot embark/disembark directly

---

### 4. **Sea Travel Multiplier** (Route Quality)
Even after embarkation, the route's sea travel multiplier affects army transit time:

```csharp
public static float SeaTravelMultiplier(TINationState movingNation, TIRegionState region1, TIRegionState region2)
{
	// If adjacent (land route), instant travel
	if (region1.IsAdjacent(region2, false))
		return 1f;

	// Check canal/strait access for the moving nation
	bool suezAccess = movingNation == null || TIRegionState.SuezAccess(movingNation);
	bool panamaAccess = movingNation == null || TIRegionState.PanamaAccess(movingNation);

	// Analyze coast regions for both origin and destination
	// Returns multiplier based on ocean accessibility
	// Can range from 1.0 (direct route) to much higher (requiring detours)
}
```

**Location:** `TIRegionState.cs` (line 988)

**Factors That Affect Multiplier:**
1. **Canal/Strait Access**:
   - **Suez Canal**: Connects Mediterranean and Indian Ocean
   - **Panama Canal**: Connects Atlantic and Pacific
   - **Turkish Strait**: Connects Mediterranean and Black Sea

2. **Coast Region Mapping**:
   - Regions map to specific ocean zones
   - Example: "IndianMed" region has access to Indian + Mediterranean
   - Example: "PacificCarib" region has access to Pacific + Caribbean

3. **Route Calculation**:
   - Finds minimum multiplier between all possible ocean routes
   - Takes best available route based on nation's access

---

## Decision Flow Diagram

```
Army Movement Requested
	↓
Is target adjacent? (AdjacentRegions check)
	├─ YES → Direct land movement (multiplier = 1.0)
	│        Army moves within same turn-based period
	│
	└─ NO → Check if sea transit possible
			 ↓
		Is current region coastal? (oceanType check)
			 ├─ NO → Movement BLOCKED - cannot embark
			 │
			 └─ YES → Is destination region coastal?
					  ├─ NO → Movement BLOCKED - cannot disembark
					  │
					  └─ YES → Calculate sea travel multiplier
							   ↓
						   Create 3 time stages:
						   1. Embarking (33%)
						   2. Sea_HomeRegion (33%)
						   3. Sea_DestinationRegion (33%)
							   ↓
						   Army becomes vulnerable to interception
```

---

## Critical Code Locations

### Army Embarkation Decision
- **File**: `TIArmyOperationTemplate.cs` (lines 80-100)
- **Method**: Region validation and sea transit setup

### Sea Transit Stages
- **File**: `TIArmyState.cs` (lines 1748-1800)
- **Methods**: `SetSeaTransitStages()`, `SeaTransitStage()`

### Adjacency Check
- **File**: `TIRegionState.cs` 
- **Method**: `AdjacentRegions()` - Returns list of adjacent regions
- **Variant**: `AdjacentRegions(true)` respects nation war status

### Coastal Definition
- **File**: `TIRegionState.cs` (line 604)
- **Property**: `isCoastal` - Determines if region can embark/disembark

### Sea Route Calculation
- **File**: `TIRegionState.cs` (line 988)
- **Method**: `SeaTravelMultiplier()` - Calculates route cost/time

---

## Example Scenarios

### Scenario 1: Adjacent Land Movement
```
Army in France moving to Germany (adjacent)
├─ AdjacentRegions(true) check: ✓ Germany is adjacent
└─ Result: Direct movement, no navy needed, multiplier = 1.0
```

### Scenario 2: Coastal to Coastal (Non-Adjacent)
```
Army in Portugal moving to Egypt (not adjacent, both coastal)
├─ AdjacentRegions(true) check: ✗ Egypt is NOT adjacent
├─ isCoastal check: ✓ Portugal is coastal
├─ Destination isCoastal check: ✓ Egypt is coastal
├─ SeaTravelMultiplier: Calculated (1.5-3.0 depending on Suez access)
└─ Result: Sea transit in 3 stages, multiplier affects total time
```

### Scenario 3: Blocked: Non-Coastal Origin
```
Army in Mongolia moving to Japan (not adjacent)
├─ AdjacentRegions(true) check: ✗ Japan is NOT adjacent
├─ isCoastal check: ✗ Mongolia is NOT coastal
└─ Result: Movement BLOCKED - cannot embark
```

### Scenario 4: Blocked: Non-Coastal Destination
```
Army in Spain moving to Austria (not adjacent)
├─ AdjacentRegions(true) check: ✗ Austria is NOT adjacent
├─ isCoastal check: ✓ Spain is coastal
├─ Destination isCoastal check: ✗ Austria is NOT coastal
└─ Result: Movement BLOCKED - cannot disembark
```

---

## Naval Interception During Transit

During **Sea_HomeRegion** and **Sea_DestinationRegion** stages, armies are vulnerable to:

1. **Enemy Naval Interception** - Enemy navies can attack during transit
2. **Naval Blockade** - Regions can be blockaded, preventing disembarkation
3. **Carrier Operations** - Naval units can disrupt transit

The three stages allow for:
- Defending/intercepting during embarkation
- Attacking during open ocean transit
- Defending/intercepting during disembarkation

---

## Key Properties Used

| Property | Determines |
|----------|-----------|
| `isCoastal` | Can embark/disembark |
| `oceanType` | Permanent vs seasonal coastal |
| `mapRegionTemplate.coast` | Which ocean zones this region touches |
| `AdjacentRegions(bool)` | Direct land travel possibility |
| `embarkDate` | When embarking begins (33% of transit time) |
| `destinationSeaDate` | When arrival occurs (100% of transit time) |
| `SeaTransitStage()` | Current stage of transit (Embarking/Sea_HomeRegion/Sea_DestinationRegion) |

---

## Summary

**The system decides embarkation eligibility through:**

1. ✓ **Adjacency Check First** - Non-adjacent regions trigger sea transit
2. ✓ **Coastal Validation** - Both origin and destination must be coastal
3. ✓ **Ocean Route Analysis** - SeaTravelMultiplier calculates optimal route based on:
   - Canal/strait access (Suez, Panama, Turkish)
   - Region coast classifications
   - Nation diplomatic status
4. ✓ **Time Stage Creation** - Three temporal stages for interception/defense
5. ✓ **Vulnerability Window** - 67% of travel time spent vulnerable to attack

This creates a sophisticated system where naval forces play a critical role in protecting sea lanes and intercepting enemy forces during vulnerable transit periods.

