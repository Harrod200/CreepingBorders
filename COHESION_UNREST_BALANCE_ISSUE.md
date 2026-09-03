# Impact Analysis: Mod Cohesion Changes on Unrest

## Problem Statement

When the mod changes the cohesion base value (via `CohesionRestStateBaseValue` setting), it breaks the vanilla cohesion-unrest relationship.

---

## Vanilla Relationship

### Cohesion Formula (line 2570)
```
cohesionRestState = 16 + impacts (clamped 0-10)
```

### Unrest Formula (line 2905)
```
unrestRestState = 10.5 - cohesion - PCGDP + armies + xenoforming + hostile (clamped 0-10)
```

### The Balance
- Cohesion base: 16
- Unrest base: 10.5
- **Inverse relationship**: Each +1 cohesion = -1 unrest

**Example:**
- Base cohesion: 16 → Results in approximately unrest base: 10.5 - 16 = -5.5 (before other factors)
- This is compensated by positive factors (armies, xenoforming, etc.) that increase unrest

---

## Problem When Mod Changes Base Value

### Scenario: User sets CohesionRestStateBaseValue = 20 (from default 16)

**Vanilla:**
- Cohesion base = 16
- Unrest base = 10.5 → Net unrest = 10.5 - 16 = -5.5 (adjusted by other factors)

**With Mod Change:**
- Cohesion base = 20 (mod changes this)
- Unrest base = 10.5 (vanilla, NOT changed)
- Net unrest = 10.5 - 20 = -9.5 (BUT THE FORMULA STILL USES 10.5!)

**Result:**
- Cohesion is +4 higher (20 vs 16)
- Unrest should be -4 lower to maintain balance
- But vanilla unrest formula STILL uses hardcoded 10.5
- **Nations become nearly impossible to have unrest with high cohesion bases**

---

## The Math

### Cohesion-Unrest Relationship

The vanilla game balances them with:
- Cohesion base: 16
- Unrest base: 10.5
- Implicit assumption: cohesion offsets 16/10.5 ≈ 1.52x of unrest base

### When Base Changes

| CohesionBase | Formula Effect | Unrest Impact | Balance |
|---|---|---|---|
| 16 (vanilla) | 16 + impacts | 10.5 - 16 = -5.5 baseline | ✅ Balanced |
| 18 | 18 + impacts | 10.5 - 18 = -7.5 baseline | ❌ Cohesion too strong |
| 20 | 20 + impacts | 10.5 - 20 = -9.5 baseline | ❌ Cohesion WAY too strong |
| 14 | 14 + impacts | 10.5 - 14 = -3.5 baseline | ❌ Cohesion too weak |

---

## Current Mod Behavior

### What the Mod Does:
```csharp
// Patch_CohesionRestState_BaseValue (line 274)
float num = CreepingBordersCls.Settings.CohesionRestStateBaseValue  // ← Modified
	+ ... (all impacts)

// Patch_UnrestDisplay (line 318-319)
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
__result = __result.Replace(oldBaseValue, newBaseValue);  // Replaces display text only
```

### Problems:
1. **Cohesion calculation changes** ✅
2. **Unrest calculation is NOT updated** ❌
3. **Display text is replaced** ⚠️ (cosmetic only, doesn't fix the calculation)

### Example Impact:
- User sets `CohesionRestStateBaseValue = 20`
- Cohesion increases by 4 everywhere
- Display shows "Base Value: 20.0" (misleading)
- Unrest formula **still uses 10.5 in calculation**
- **Actual unrest values DON'T change proportionally**
- **Nations become drastically more stable** (unintended consequence)

---

## Is This Actually a Problem?

### Depends on Design Intent:

#### If Intended: "Let player configure cohesion strength"
- ✅ Current behavior might be acceptable
- ⚠️ But creates balance issues (unrest doesn't scale with cohesion)
- 🔴 Makes high cohesion bases make unrest irrelevant

#### If Intended: "Maintain vanilla balance but adjust cohesion base"
- ❌ Current implementation is WRONG
- 🔴 Unrest base should also change proportionally
- 🔴 Or unrest formula should incorporate the configured base value

---

## Comparison with NoDistanceCohesionMalus

### How NoDistanceCohesionMalus Works (Line 279):
```csharp
(CreepingBordersCls.Settings.NoDistanceCohesionMalus ? 0f : __instance.regionsImpactOnCohesion)
```
- Changes a **component** of the calculation
- Doesn't alter fundamental relationships

### How CohesionRestStateBaseValue Works:
```csharp
CreepingBordersCls.Settings.CohesionRestStateBaseValue  // ← Fundamental base value
```
- Changes the **foundation** of the calculation
- **Breaks the relationship** with unrest if unrest isn't updated

**Key Difference:** 
- NoDistanceCohesionMalus: Removes ONE factor (safe)
- CohesionRestStateBaseValue: Changes fundamental balance (unsafe without unrest update)

---

## Recommendation

### Option A: Fix the Calculation (Recommended)
Patch `unrestRestState` to use a configurable base value:

```csharp
// Instead of hardcoded 10.5
float unrestBase = CalculateUnrestBase(); // Derived from CohesionRestStateBaseValue
return Mathf.Clamp(
	unrestBase - cohesion - PCGDP + armies + xenoforming + hostile,
	0f, 10f
);
```

**Relationship that should be maintained:**
```
unrestBase = 10.5 × (CohesionRestStateBaseValue / 16)
```

For `CohesionRestStateBaseValue = 16`: unrestBase = 10.5 (vanilla)
For `CohesionRestStateBaseValue = 20`: unrestBase = 13.125 (proportional)

### Option B: Document the Limitation
- Leave the display patch as-is
- Document that changing `CohesionRestStateBaseValue` affects cohesion but not unrest balance
- Let players know this creates an imbalance

### Option C: Disable the Base Value Setting
- Remove the ability to change cohesion base value
- Simplify the mod to only handle:
  - NoDistanceCohesionMalus (affects one component)
  - EnableDiscontiguityMalus (affects one component)
  - NoPopulationMalus (affects one component)

---

## Impact If NOT Fixed

### With CohesionRestStateBaseValue = 20:
- Nation cohesion will be ~4 points higher
- Nation unrest will NOT decrease proportionally
- **Result**: Nations become nearly immune to unrest
- **Gameplay**: Balance is broken, wars and unrest become non-factors
- **Player experience**: Game becomes too easy

### With CohesionRestStateBaseValue = 14:
- Nation cohesion will be ~2 points lower
- Nation unrest will NOT increase proportionally
- **Result**: Nations become unstable too easily
- **Gameplay**: Constant unrest issues
- **Player experience**: Game becomes too hard

---

## Verdict

🔴 **ISSUE CONFIRMED: The unrest base value should be updated when cohesion base value changes, or the feature should be disabled/documented.**

Current behavior creates **unintended gameplay imbalance**.

