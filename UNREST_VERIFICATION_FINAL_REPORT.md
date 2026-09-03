# UnrestRestStateDetail Verification Report - FINAL

## Executive Summary

🔴 **CRITICAL ISSUES FOUND: The unrestRestStateDetail display is NOT accurately reflecting the actual unrest calculations.**

### Issues Identified:
1. **Base value replacement is incorrect** - Shows cohesion base, calculation uses unrest base
2. **Discontiguity sign is misleading** - Shows negative (reducing unrest), actually increases it
3. **Underlying calculation is broken** - Unrest base doesn't scale with cohesion base changes
4. **Display doesn't match math** - Values shown don't add up to the calculated unrest

---

## Detailed Findings

### 🔴 Issue 1: Broken Cohesion-Unrest Relationship

#### Vanilla Balance:
- Cohesion base: **16**
- Unrest base: **10.5**
- Formula: `unrest = 10.5 - cohesion - PCGDP + armies + xenoforming + hostile`
- These are tightly coupled for game balance

#### With Mod's CohesionRestStateBaseValue = 20:
- Cohesion base: **20** (mod changes this)
- Unrest base: **10.5** (vanilla, unchanged)
- Problem: **The inverse relationship is broken**

**Example:**
```
Vanilla Nation:
  Cohesion Rest State: 16 (base) + impacts = 8
  Unrest Rest State: 10.5 - 8 = 2.5

With Mod (base=20):
  Cohesion Rest State: 20 (base) + impacts = 12
  Unrest Rest State: 10.5 - 12 = -1.5 → clamped to 0

Result: ZERO UNREST! (Should have increased, not decreased)
```

**Impact**: Nations become essentially unrest-immune when cohesion base is high.

---

### 🔴 Issue 2: Misleading Display Base Value

#### Current Display Patch Code:
```csharp
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // e.g., "20.0"
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

#### Problem:
- Replaces display string "10.5" with "20.0"
- **But the calculation STILL uses 10.5**
- Display is now **LYING to the player**

#### Example Display:
```
Unrest Rest State Breakdown
Base Value: 20.0  ← WRONG! Calculation uses 10.5
From Cohesion: -8.0
From PC-GDP: +0.2
...
Unrest Limits: 2.3
```

**Player sees:** "Base is 20.0 - 8.0 = 12, plus adjustments = 2.3"
**Reality:** "Base is 10.5 - cohesion (which is affected by 20.0 base)"
**Mismatch:** Display doesn't match math

---

### 🔴 Issue 3: Discontiguity Sign Is Inverted

#### How Discontiguity Works:
```
Discontiguity → Affects Cohesion (-1.5)
Cohesion Inversely Affects Unrest (higher cohesion = lower unrest)
Result: -1.5 cohesion → +1.5 unrest
```

#### Current Display:
```
FromDiscontiguity: -1.5
```

#### Problem:
- Shows negative value
- Player reads this as: "Discontiguity reduces unrest by 1.5"
- **Actually means:** "Discontiguity increases unrest by 1.5" (via cohesion reduction)
- **Sign is backwards** relative to unrest impact

#### Correct Display Should Show:
```
FromDiscontiguity (effect on unrest): +1.5
```

Or better, integrate into cohesion line:
```
From Cohesion (including discontiguity): -9.5
```

---

### 🔴 Issue 4: Display-Calculation Mismatch

#### Example Scenario:
Nation with:
- Discontiguity malus: -1.5 on cohesion
- CohesionRestStateBaseValue: 20 (instead of 16)
- Actual cohesion: 12
- PCGDP: 0.2
- Armies: 1.0

#### Display Shows:
```
Base Value: 20.0
From Cohesion: -12.0  (actual cohesion value)
FromDiscontiguity: -1.5  (cohesion impact shown with same sign)
From PC-GDP: +0.2
From Armies: +1.0
Unrest Limits: 7.7
```

#### What Player Calculates:
20.0 - 12.0 - 1.5 + 0.2 + 1.0 = 7.7 ✓ Matches!

#### But Actual Calculation:
```
unrest = 10.5 - cohesion - PCGDP + armies  (vanilla formula, unchanged)
	   = 10.5 - 12 - 0.2 + 1.0
	   = -0.7 → clamped to 0
```

#### Result:
- **Display says: 7.7**
- **Actual calculation: 0**
- **Display is COMPLETELY WRONG**

---

## Root Cause Analysis

### The Core Problem:

The mod changed the **cohesion calculation** but didn't update the **unrest calculation**.

**Cohesion Patch** (Line 274):
```csharp
float num = CreepingBordersCls.Settings.CohesionRestStateBaseValue  ← Configurable
	+ ... impacts
```

**Unrest Calculation** (Vanilla, unchanged):
```csharp
return Mathf.Clamp(10.5f - this.cohesion - PCGDP + armies + ..., 0f, 10f);  ← Hardcoded
```

**Result**: Cohesion and unrest are decoupled.

### The Display Patch Makes It Worse:

By trying to make the display match the cohesion base, it creates a **false sense of accuracy** while hiding the underlying broken calculation.

---

## Severity Assessment

### 🔴 CRITICAL: Gameplay Broken
- Nations with high cohesion bases become unrest-proof
- Unrest mechanic becomes irrelevant
- Game balance is destroyed
- Player doesn't understand why

### 🔴 CRITICAL: Player Confusion
- Display shows wrong values
- Display doesn't match calculations
- Player can't trust the UI
- Players may think they found a bug (they did)

### 🔴 CRITICAL: Design Intent Unknown
- Unclear if cohesion base change was intentional
- Unclear if unrest was supposed to scale with it
- Unclear if display is intentionally misleading

---

## What Should Happen

### Option A: Fix Both Calculations (Recommended)

**Patch `TINationState.unrestRestState`:**
```csharp
public float unrestRestState
{
	get
	{
		if (this.extant)
		{
			// Derive unrest base proportionally from cohesion base
			float unrestBase = 10.5f * (CreepingBordersCls.Settings.CohesionRestStateBaseValue / 16f);

			return Mathf.Clamp(
				unrestBase 
				- this.cohesion 
				- this.perCapitaGDPEffectOnUnrest 
				+ this.armyImpactOnUnrest 
				+ this.xenoformingImpactOnUnrest 
				+ this.hostileClaimsImpactOnUnrest, 
				0f, 10f
			);
		}
		return 0f;
	}
}
```

**Fix Display Patch:**
```csharp
// DON'T replace base value - it should always be 10.5 (or derived value if using Fix above)
// DO show discontiguity with correct meaning for unrest
float discontiguityUnrestImpact = -discontiguityImpact;  // Flip sign
string discontiguityLine = "From Discontiguity Impact: " + 
	discontiguityUnrestImpact.ToString("N1") + "\n";
```

### Option B: Disable CohesionRestStateBaseValue Feature

Remove the ability to change cohesion base value entirely:
```csharp
// public bool CohesionRestStateBaseValue = 16f;  ← REMOVE
// Keep only: NoDistanceCohesionMalus, EnableDiscontiguityMalus, NoPopulationMalus
```

This keeps the mod focused on **removing maluses**, not **changing fundamental balance**.

### Option C: Document the Limitation

Add a note stating:
> "Changing CohesionRestStateBaseValue affects cohesion but creates an imbalance with unrest. Use with caution or keep at 16.0 for vanilla balance."

---

## Verdict

| Finding | Status | Severity | Action |
|---------|--------|----------|--------|
| Base value replacement | ❌ Wrong | 🔴 Critical | Remove or fix calculation |
| Discontiguity sign | ❌ Misleading | 🔴 Critical | Show inverted for unrest |
| Cohesion-unrest relationship | ❌ Broken | 🔴 Critical | Patch unrestRestState or disable feature |
| Display accuracy | ❌ Inaccurate | 🔴 Critical | Recalculate display values |

**Overall Assessment: 🔴 UNREST DISPLAY IS NOT REFLECTING CORRECT CALCULATIONS**

The mod's current implementation creates a false sense of accuracy while actually breaking the game's cohesion-unrest mechanics. **Immediate fixes are needed.**

---

## Recommended Action

**Immediate Priority:**
1. Disable or fix the base value replacement
2. Either patch unrestRestState to use configurable base, or revert cohesion base value to 16
3. Fix discontiguity sign in display
4. Test in-game to verify calculations match display

**Long-term:**
- Decide on design: Is variable cohesion base intended?
- If yes, ensure unrest scales proportionally
- If no, remove the setting and simplify the mod

