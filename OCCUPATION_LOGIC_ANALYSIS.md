# Terra Invicta Region Occupation Logic Analysis

## Overview
The invasion and occupation system in Terra Invicta allows armies to take control of enemy regions through a multi-stage process. This document describes the core logic for how an invading army occupies a **TIRegionState**.

---

## Key Concepts

### 1. **Occupation Values Dictionary**
```csharp
public Dictionary<TINationState, float> occupations { get; private set; }
```
- Each region maintains a dictionary tracking occupation progress for each nation
- Values range from **0.0 (no occupation) to 1.0 (fully occupied)**
- Multiple nations can have simultaneous occupation values in a contested region
- Values are clamped between 0 and 1 to prevent overflow/underflow

### 2. **Lead Occupier**
```csharp
public TINationState leadOccupier { get; private set; }
```
- The nation currently controlling the region (reaches 1.0 occupation)
- Only set when a nation reaches 100% occupation
- Determines who effectively owns/controls the region once fully occupied
- Changes trigger region control transfer events

---

## Core Occupation Methods

### **IncreaseOccupationValue()**
```csharp
public void IncreaseOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)
```

**Purpose:** Incrementally increases occupation progress for a nation in a region.

**Logic Flow:**
1. If value is 0, method exits (no-op)
2. Records current occupancy status before the change
3. If occupying nation already has an occupation value:
   - Adds the new value to existing value
   - Clamps result between 0.0 and 1.0
4. If occupying nation has no prior occupation:
   - Adds new entry with the clamped value
5. Triggers `RegionOccupationValueChange` event
6. If value > 0 (increasing occupation):
   - Calls `CheckAndTriggerOccupation()` to check if full occupation achieved
7. If value < 0 (decreasing occupation) AND region was fully occupied:
   - Recalculates the lead occupier
   - Triggers `OccupationStatusChange` event

**Example Usage:**
- Army in region adds incremental occupation each turn
- Slowly builds from 0% to 100%
- Multiple armies from the same nation stack their progress

---

### **SetOccupationValue()**
```csharp
public void SetOccupationValue(TINationState occupyingNation, float value, TIArmyState army = null)
```

**Purpose:** Directly sets occupation value (replaces incremental approach).

**Logic Flow:**
1. If nation already has occupation:
   - Sets value directly (clamped 0-1)
2. If nation has no occupation AND value > 0:
   - Creates new occupation entry
3. Triggers `RegionOccupationValueChange` event
4. Calls `CheckAndTriggerOccupation()` to process full occupation

**Difference from IncreaseOccupationValue:**
- Sets value outright instead of adding to existing
- Used for events that directly establish occupation (e.g., initialization, special effects)

---

### **CheckAndTriggerOccupation()**
```csharp
public void CheckAndTriggerOccupation(TIArmyState army)
```

**Purpose:** Determines if full occupation (100%) is achieved and completes the occupation process.

**Conditions for Full Occupation:**
```csharp
// Occupation is NOT triggered if:
army != null && army.CanReduceOccupation() // Army is liberating (not occupying)

// Occupation IS triggered if:
!this.IsFullyOccupied() || 
  (army != null && !army.InBattleWithArmies() && 
   (!this.GetOccupyingAlliance(false).Contains(army.homeNation) || 
	army.AlienRegularArmy))
```

**Process:**
1. Records current lead occupier
2. If an alien regular army and alien nation doesn't already have full occupation:
   - Sets lead occupier to alien nation
3. Otherwise:
   - Calls `SetLeadOccupier()` to recalculate based on highest occupation values
4. If lead occupier changed:
   - Calls `CompleteOccupationofRegion(army)` to transfer control
   - Triggers `OccupationStatusChange` event

---

### **CompleteOccupationofRegion()**
```csharp
private void CompleteOccupationofRegion(TIArmyState army)
```

**Purpose:** Executes the actual region control transfer when a nation reaches full occupation.

**Key Logic:**

#### **Case 1: Occupying Nation's Capital**
- If region IS the occupying nation's capital, occupation is blocked unless it's an alien nation with multiple regions
- Prevents capital seizure in most scenarios

#### **Case 2: Normal Region Occupation**
- If it's an alien army (not mega fauna) occupying:
  - Transfers region to alien nation
  - Creates alien nation if it doesn't exist
  - Clears all occupation values
- If alien nation is the original owner:
  - Determines which nation gets the region based on scoring:
	- **Capital holders**: +4 points
	- **Adjacent nations**: +2 points
	- **Same executive faction**: +1 point
  - Randomly selects winner among tied highest scorers
  - Establishes alliances if needed

#### **Case 3: Regional Control Transfer**
- Uses `TransferRegionsControlTo()` method
- Parameters:
  - **List of regions** to transfer (just this one)
  - **Destination nation** (occupying nation)
  - **War setup flags** controlling peace/war status

---

## Occupation State Checks

### **IsFullyOccupied()**
```csharp
return this.leadOccupier != null
```
- Returns true only when a lead occupier is established
- Indicates 100% occupation with clear controller

### **OccupiedOrOccupationUnderway()**
```csharp
if (this.occupations.Count > 0)
	return this.occupations.Values.Any<float>((float x) => x > 0f);
```
- True if any nation has ANY occupation progress (> 0%)
- True during the occupation process OR when fully occupied
- Indicates region is contested or under control

### **OccupationUnderwayButNotComplete()**
```csharp
if (this.occupations.Count > 0 && this.leadOccupier == null)
	return this.occupations.Values.Any<float>((float x) => x > 0f && x < 1f);
```
- True if occupation is ongoing (>0% and <100%)
- No lead occupier established yet (still contested)
- Indicates active occupation in progress

### **NoOccupationUnderwayOrComplete()**
```csharp
if (this.occupations.Count != 0)
	return this.occupations.Values.All<float>((float x) => x == 0f);
```
- True if all occupation values are exactly 0%
- Region has no occupying forces

---

## Army Occupation Methods

### **OccupyingRegion(bool includeLiberation = true)**
```csharp
public virtual bool OccupyingRegion(bool includeLiberation = true)
{
	return (includeLiberation && this.CanReduceOccupation()) || 
		   (!this.InBattleWithArmies() && 
			(this.homeNation.wars.Contains(this.currentNation) || !this.homeNation.extant) && 
			this.currentOperations.Count == 0 && 
			(!this.currentRegion.IsFullyOccupied() || 
			 (this.AlienRegularArmy && !this.OccupierInCurrentRegion())));
}
```

**Returns true if army is occupying when:**
1. **Liberation Mode** (`includeLiberation=true`):
   - Army can reduce occupation (is liberating)
2. **Occupation Mode** (`includeLiberation=false`):
   - Army is NOT in battle with other armies
   - Army's home nation is at war with current region's nation OR home nation is extinct
   - Army has no active operations
   - Region is NOT fully occupied OR (it's an alien regular army AND alien nation doesn't occupy it yet)

---

## Occupation During War

When occupation value increases via `IncreaseOccupationValue()`:
```csharp
foreach (TIWarState tiwarState in currentWarStates.Where<TIWarState>(func))
{
	tiwarState.FightingOccurs();
}
```

- All active wars involving the occupying nation trigger `FightingOccurs()`
- This updates war momentum and keeps wars active
- Prevents wars from ending while occupation is ongoing

---

## Occupation Validation & Cleanup

### **ValidateAndCleanOccupations()**
```csharp
public void ValidateAndCleanOccupations()
```

**Purpose:** Removes invalid occupation entries and maintains consistency.

**Process:**
1. Iterates through all occupation entries
2. Removes entries for nations that no longer exist or are no longer at war
3. If any entries removed:
   - Triggers `OccupationStatusChange` event

---

## Multi-Nation Occupation (War Alliances)

### **GetHighestWarAllianceOccupationValue()**
```csharp
public float GetHighestWarAllianceOccupationValue(out TINationState leaderOfLeadingAlliance, 
												   out List<TINationState> occupyingAlliance)
```

**Purpose:** Aggregates occupation values across allied nations in a war.

**Logic:**
1. Groups occupation values by war (all allies in same war combined)
2. Sums occupation values for all nations in each war alliance
3. Returns:
   - **Highest aggregated occupation value** across all alliances (capped at 1.0)
   - **Leader nation**: The single nation with highest individual occupation value in winning alliance
   - **Occupying alliance**: List of all nations from the winning war alliance

**Example:**
- Nation A has 0.6 occupation, Nation B (ally of A) has 0.5 occupation
- Aggregated value = 1.0 (min(0.6 + 0.5, 1.0))
- Region control transfers to whichever of A or B has the individual highest value

---

## Lead Occupier Determination

### **SetLeadOccupier()**
Similar to `GetLeadOccupierInFullOccupation()`:
1. Checks if highest war alliance has ≥1.0 occupation
2. If yes:
   - Sorts nations by individual occupation value (descending)
   - Secondary sort: Military strength
   - First nation becomes lead occupier

---

## Occupation Speed & Configuration

From `TIGlobalConfig`:
```csharp
public float occupationSpeed = 1f;  // Base modifier for occupation rate
```

**Usage:**
- Applied to army actions that increase occupation per turn
- Higher value = faster occupation
- Affects how quickly armies progress toward full occupation

---

## Events Triggered During Occupation

| Event | Triggered When |
|-------|----------------|
| `RegionOccupationValueChange` | Any occupation value changes |
| `OccupationStatusChange` | Full occupation achieved or lead occupier changes |
| `RegionControlChanged` | Region control transfers to new nation |
| `OccupationStatusChange` | Invalid occupations cleaned up |

---

## Summary: Step-by-Step Occupation Process

1. **Army Enters Enemy Region in War**
   - Region has no occupation yet
   - Army begins occupation action

2. **Occupation Increments Each Turn**
   - `IncreaseOccupationValue()` called with small value (e.g., +0.05)
   - Occupation value grows: 0.05 → 0.10 → 0.15 ... → 1.0
   - Other nations' armies in region can increase their own occupation values (contested)

3. **Reaching Full Occupation**
   - When any nation's occupation reaches 1.0
   - `CheckAndTriggerOccupation()` fires
   - Allied occupations are aggregated

4. **Determining Winner (Lead Occupier)**
   - War alliances are evaluated
   - Highest aggregate occupation wins
   - Within winning alliance, nation with highest individual occupation becomes lead occupier

5. **Region Control Transfer**
   - `CompleteOccupationofRegion()` executes
   - Region's `nation` property changes to occupying nation
   - All occupation values cleared (new owner has 100%)
   - Events fired to update UI and game state

6. **Post-Occupation**
   - Region now belongs to occupying nation
   - Armies can defend or move on
   - Defeated nation loses region permanently (unless liberated by another war)

---

## Related Concepts

### **Liberation vs. Occupation**
- **Occupation**: Increasing a region's value (0 → 100%)
- **Liberation**: Decreasing occupation values back to 0% (only for nations NOT at war with region's nation)

### **Annexation** (Different from Occupation)
- Occurs AFTER full occupation
- Army remains in region for days/weeks to officially annex it
- Processed by `BeginAnnexation()` and annexation timers

### **Alien Occupation**
- Alien armies can occupy regions even without declared war
- Alien regular armies trigger special occupation logic
- May automatically establish alien nation control if alien nation doesn't exist

