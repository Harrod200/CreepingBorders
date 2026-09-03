# Vanilla Terra Invicta Annexation Process

## Overview
Annexation is a **separate, post-occupation** process in vanilla Terra Invicta. It's a timed operation that must be manually initiated after a region is fully occupied.

---

## Key Differences: Occupation vs. Annexation

| Phase | Occupation | Annexation |
|-------|-----------|-----------|
| **Trigger** | Automatic (when army occupies region) | Manual (player initiates operation) |
| **Prerequisite** | None (starts at 0%) | Region must be 100% occupied |
| **Duration** | Incremental (multiple turns) | Fixed timer (45-270 days) |
| **Control** | Region changes owner at completion | Region already owned; annexation confirms it |
| **Army Required** | Any army (any strength) | Human army with strength ≥ armyStrengthToLiberate |

---

## Annexation Requirements

### ValidRegionToAnnexOrLiberate() Checks
```csharp
public bool ValidRegionToAnnexOrLiberate(TIArmyState army)
{
	return !this.isBeingAnnexed &&                                    // Not already annexing
		   army.homeNation.wars.Contains(army.currentNation) &&       // Home nation at war with region's nation
		   (army.homeNation.claims.Contains(army.currentRegion) ||    // Region is claimed OR
			TIRegionState.LiberationTarget(army) != null) &&          // Can liberate it
		   army.currentNation.capital != this &&                      // NOT the capital
		   army.currentRegion.IsFullyOccupied() &&                    // 100% occupied
		   army.currentRegion.GetOccupyingAlliance(false)
			   .Contains(army.homeNation);                            // Home nation in occupying alliance
}
```

**All conditions must be met:**
1. ✓ Region is not already being annexed
2. ✓ Home nation is at war with region's current owner
3. ✓ Either:
   - Home nation has a claim on the region, OR
   - There's a valid liberation target (secession candidate)
4. ✓ Region is NOT the capital of the current owner
5. ✓ Region is at 100% occupation
6. ✓ Home nation is in the occupying alliance

### Army Requirements
```csharp
private bool ArmyCanAnnex(TIArmyState army)
{
	return army.armyType == ArmyType.Human &&                    // Must be a human army (not alien/AI)
		   !army.InBattleWithArmies() &&                         // Not currently in combat
		   army.strength >= TIGlobalConfig.globalConfig
			   .armyStrengthToLiberate &&                        // Strength ≥ threshold
		   army.currentRegion.ValidRegionToAnnexOrLiberate(army); // Passes all region checks
}
```

---

## Annexation Duration Calculation

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, 
									   Trajectory trajectory = null)
{
	TIArmyState ref_army = actorState.ref_army;
	TIRegionState ref_region = target.ref_region;

	return Mathf.Clamp(
		90f                                           // Base duration: 90 days
		* ref_region.RegionArmyActionMultiplier(false) // Modified by region population/size
		* ((ref_region.terrain == TerrainType.Rugged) // Rugged terrain adds 25%
		   ? 1.25f 
		   : 1f)
		/ (ref_region.nation.militaryTechLevel       // Defender's tech level
		   / ref_army.techLevel),                     // Divided by attacker's tech
		45f,   // Minimum: 45 days
		270f   // Maximum: 270 days (9 months)
	);
}
```

**Formula Breakdown:**
- **Base**: 90 days
- **Multipliers**:
  - Region population/size factor
  - +25% if terrain is Rugged
  - Defender military tech level ÷ Attacker military tech level
- **Clamped**: 45–270 days

**Example**: 
- Large, rugged region with high-tech defender vs. lower-tech attacker = longer annexation
- Small region with low-tech defender vs. high-tech attacker = shorter annexation

---

## Annexation Process Flow

### 1. **Operation Initiation**
```csharp
public override bool OperationConfirmed(TIGameState actor, TIGameState target, 
										TIDateTime opCompleteDate)
{
	if (base.OperationConfirmed(actor, target, opCompleteDate))
	{
		TIArmyState ref_army = actor.ref_army;
		ref_army.currentRegion.BeginAnnexation(ref_army, 
			this.GetDuration_days(actor, target, null));
		return true;
	}
	return false;
}
```

**When player selects "Annex Region" operation:**
1. Operation validity is confirmed
2. `BeginAnnexation()` is called
3. Timer starts counting down

### 2. **BeginAnnexation() Setup**
```csharp
public void BeginAnnexation(TIArmyState annexingArmy, float days)
{
	this.isBeingAnnexed = true;
	this.annexationBeginDate = TITimeState.Now();
	if (days <= 1f)
		days = 1f;
	this.annexationDaysLeft = days;
	this.annexingArmy = annexingArmy;

	GameControl.eventManager.TriggerEvent(
		new RegionAnnexationValueChange(this, annexingArmy), null, ...);
}
```

**Sets:**
- `isBeingAnnexed` = true (blocks other annexations)
- `annexationBeginDate` = current game time
- `annexationDaysLeft` = calculated duration (min 1 day)
- `annexingArmy` = reference to performing army
- Triggers UI event to show timer

### 3. **Daily Countdown: AnnexationDay()**
```csharp
public void AnnexationDay()
{
	if (this.CheckAndEndAnnexation(false))
		return;

	this.annexationDaysLeft -= 1f;

	// Update war momentum
	List<TIWarState> list = this.annexingArmy.homeNation
		.findWarsWith(this.nation);
	list.ForEach(delegate(TIWarState x)
	{
		x.FightingOccurs();
	});

	// Check if annexation complete
	if (this.annexationDaysLeft < 1f)
	{
		// TRANSFER OWNERSHIP (see below)
	}
}
```

**Each day:**
1. Checks if annexation should be canceled
2. Decrements `annexationDaysLeft` by 1
3. Triggers `FightingOccurs()` on all active wars
4. When timer reaches 0, transfers region ownership

### 4. **Ownership Transfer: Annexation Complete**
```csharp
if (this.annexationDaysLeft < 1f)
{
	TINationState nation = this.nation; // Original owner

	// CASE 1: Region is claimed
	if (this.annexingArmy.homeNation.claims.Contains(this.annexingArmy.currentRegion))
	{
		this.nation.TransferRegionsControlTo(
			new List<TIRegionState> { this },
			this.annexingArmy.homeNation,
			true,   // destroyArmies = true (clear defending armies)
			false,  // suppressReporting = false (show notification)
			false,
			false,
			false
		);
	}
	// CASE 2: Liberation (no claim, but secession candidate exists)
	else
	{
		TINationState tinationState = TIRegionState.LiberationTarget(this.annexingArmy);
		if (tinationState != null)
		{
			// Ally with liberated nation
			this.annexingArmy.homeNation.InitiateAlliance(
				this.annexingArmy.faction, tinationState);

			// Perform secession
			this.annexingArmy.currentNation.Secession(
				this.annexingArmy.faction,
				tinationState,
				new List<TIRegionState> { this.annexingArmy.currentRegion },
				this.annexingArmy.homeNation);

			// Declare war if needed
			if (nation.ValidNewWarTarget(tinationState, false))
			{
				nation.DeclareFullWar(null, tinationState);
			}
		}
	}
}
```

**Two Outcomes:**

**Option A: Annexation (Region Claimed)**
- Region transfers directly to annexing nation
- Defending armies destroyed
- War momentum updated
- Notification shown

**Option B: Liberation (No Claim, Secession Candidate)**
- Region doesn't transfer to annexing nation
- Instead, it transfers to secession candidate nation
- Annexing nation forms alliance with liberated nation
- New war may be declared against original owner

---

## Annexation Cancellation: CheckAndEndAnnexation()

```csharp
public bool CheckAndEndAnnexation(bool force)
{
	bool flag = false;

	if (force)
	{
		flag = true;
	}
	else if (this.isBeingAnnexed)
	{
		// Check if all conditions still valid
		if (TIGameState.Valid(this.annexingArmy) &&
			this.annexingArmy.strength > armyStrengthToLiberate &&
			this.annexingArmy.currentRegion == this &&      // Army still in region
			!this.annexingArmy.atSea &&                     // Not at sea
			this.annexingArmy.CurrentOperations().Count != 0) // Has operations
		{
			// All operation checks pass, check detailed conditions
			if (this.annexingArmy.homeNation
				.wars.Contains(this.annexingArmy.currentNation))
			{
				// Still at war
				if (this.annexingArmy.homeNation.claims
					.Contains(this.annexingArmy.currentRegion) ||
					TIRegionState.LiberationTarget(this.annexingArmy) != null)
				{
					// Still has claim or liberation target
					if (this.annexingArmy.currentNation.capital != this &&
						this.annexingArmy.currentRegion.IsFullyOccupied() &&
						this.annexingArmy.currentRegion.GetOccupyingAlliance(false)
							.Contains(this.annexingArmy.homeNation))
					{
						// All valid - continue annexation
						goto IL_0154;
					}
				}
			}
		}
		flag = true; // Condition failed, cancel
	}

	IL_0154:
	if (flag)
	{
		this.EndAnnexation();
	}
	return flag;
}
```

**Annexation is CANCELED if any of these occur:**
1. Army is destroyed or invalid
2. Army leaves the region
3. Army goes at sea
4. Annexation operation is manually canceled
5. War between nations ends
6. Nation loses claim on region
7. Liberation target becomes unavailable
8. Region's owner loses full occupation control

---

## Annexation Cancellation: EndAnnexation()

```csharp
public void EndAnnexation()
{
	if (this.isBeingAnnexed)
	{
		if (TIGameState.Valid(this.annexingArmy))
		{
			// Find and cancel the AnnexRegionOperation
			OperationData operationData = null;
			foreach (OperationData operationData2 in 
				this.annexingArmy.CurrentOperations())
			{
				if (operationData2.operation is AnnexRegionOperation && 
					operationData2.target == this)
				{
					operationData = operationData2;
				}
			}
			if (operationData != null)
			{
				// Cancel the timed operation
				GameTimeManager.Singleton.CancelTimeEvent(
					this.annexingArmy.armyOperationCompleteEventName,
					this.annexingArmy, this, 
					operationData.operation as TIOperationTemplate,
					operationData.completionDate);
				this.annexingArmy.RemoveOperation(operationData);
			}
		}
		this.isBeingAnnexed = false;
		this.annexingArmy = null;
		this.annexationBeginDate = null;

		// Trigger UI update
		GameControl.eventManager.TriggerEvent(
			new RegionAnnexationValueChange(this, this.annexingArmy), null, ...);
	}
}
```

---

## Resource Cost

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, 
														  TIGameState target, 
														  TIGameState actor, 
														  bool checkCanAfford = true)
{
	TIResourcesCost tiresourcesCost = new TIResourcesCost(
		FactionResource.Influence, 100f);
	tiresourcesCost.SetCompletionTime_Days(
		this.GetDuration_days(actor, target, null));
	return new List<TIResourcesCost> { tiresourcesCost };
}
```

- **Cost**: 100 Influence
- **Time to Pay**: Spread over annexation duration (not upfront)

---

## Progress Tracking: PercentAnnexed()

```csharp
public float PercentAnnexed()
{
	if (this.isBeingAnnexed)
	{
		return (float)(TITimeState.Now()
			.DifferenceInDays(this.annexationBeginDate) / 
			this.annexationEndDate
			.DifferenceInDays(this.annexationBeginDate));
	}
	return 0f;
}
```

Returns `0.0–1.0` representing progress:
- `0.0` = Just started
- `0.5` = Halfway done
- `1.0` = Complete (ready to finalize)

Displayed in UI as progress bar/timer.

---

## Summary: Two-Phase System

### Phase 1: Occupation (Automatic)
```
Army enters region → Occupation 0% → Increments daily → Reaches 100%
```

### Phase 2: Annexation (Manual)
```
Player initiates annexation operation → Timer counts down (45-270 days)
→ Check conditions daily → If all valid, count down → Complete
→ Transfer region ownership → War momentum updated
```

**Key Insight**: In vanilla, occupation happens fast (a few turns), but annexation 
is the **long, manual process** that actually transfers the region. Your patch 
speeds up the occupation phase for claimed regions, still allowing the manual 
annexation phase to follow if desired.

