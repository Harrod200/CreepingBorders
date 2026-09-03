# Unrest Calculation Analysis

## Vanilla Unrest Formula

### unrestRestState (line 2901-2910)
```csharp
public float unrestRestState
{
	get
	{
		if (this.extant)
		{
			return Mathf.Clamp(
				10.5f 
				- this.cohesion 
				- this.perCapitaGDP / TIGlobalValuesState.PCGDPToReduceUnrestBy1 
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

**Formula breakdown:**
```
unrestRestState = 10.5 - cohesion - perCapitaGDPBonus + armyPenalty + xenoformingPenalty + hostilePenalty
Clamped to [0, 10]
```

### unrestRestState_unclamped (line 2912-2921)
Same formula but **without clamping** - used for display in "Unrest Limits" line

### Display Components (line 2949-2999)

The `unrestRestStateDetail` builds a display with these components:

1. **Base Value**: `10.5f` (hardcoded)
2. **From Cohesion**: Negative of cohesion value (because higher cohesion reduces unrest)
3. **From PCGDP**: `perCapitaGDPEffectOnUnrest` (calculated as `perCapitaGDP / PCGDPToReduceUnrestBy1`)
4. **From Armies**: `armyImpactOnUnrest`
5. **From Xenoforming**: `xenoformingImpactOnUnrest`
6. **From Hostile Claims**: `hostileClaimsImpactOnUnrest`
7. **Unrest Limits**: Final unclamped value

---

## Issue Identification

### ⚠️ CRITICAL ISSUE: Base Value Mismatch

**The Problem:**
The mod's `Patch_CohesionRestState_BaseValue` changes the cohesion calculation to use a configurable base value instead of hardcoded `16f`. However, the unrest calculation **still uses hardcoded `10.5f`** and there's **NO inverse relationship adjustment**.

**Why this matters:**
- When mod changes cohesion base from 16 to (e.g.) 18, cohesion values increase
- When cohesion increases, unrest DECREASES (because formula is `10.5 - cohesion`)
- But the unrest base value (10.5) remains fixed
- This creates an **asymmetry** in the relationship

### ⚠️ ISSUE: Display Patch Logic

The display patch tries to replace base value string:
```csharp
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // e.g., "18.0"
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

**Problems:**
1. This assumes unrest base should match cohesion base (not necessarily correct)
2. The vanilla unrest formula doesn't use CohesionRestStateBaseValue at all
3. Simply replacing "10.5" with "18.0" in the display is **cosmetic only** - doesn't affect actual calculations
4. If CohesionRestStateBaseValue is 18.0, replacing text gives misleading display

### ⚠️ ISSUE: Discontiguity Display Insertion

The patch adds:
```csharp
string discontiguityLine = "FromDiscontiguity: " + formattedValue + "\n";
__result = __result.Insert(insertIndex, discontiguityLine);
```

**Problems:**
1. The display shows discontiguity impact, but **unrest calculation doesn't include it**
2. Unrest uses: `10.5 - cohesion - PCGDP + armies + xenoforming + hostile`
3. Discontiguity affects **cohesion**, not **unrest directly**
4. **This is actually correct** - discontiguity affects cohesion, which inversely affects unrest
5. But the display of "FromDiscontiguity" is **misleading** because it's not a direct term in the unrest formula

---

## How Unrest Actually Gets Affected by Discontiguity

### Direct Path:
```
Discontiguity Malus → Reduces Cohesion → Increases Unrest (inverse relationship)
```

### Example:
- Cohesion drops by -1.5 due to discontiguity
- Unrest formula: `10.5 - (cohesion - 1.5)` = `10.5 - cohesion + 1.5`
- Unrest increases by +1.5

### Display Issue:
The patch shows "FromDiscontiguity: -1.5" but this is **confusing** because:
- The unrest formula doesn't explicitly have a discontiguity term
- The discontiguity effect on unrest is the **inverse** of its effect on cohesion
- A negative discontiguity malus on cohesion means positive unrest impact

**Current Display:**
```
Base Value: 10.5
From Cohesion: -8.0
From Discontiguity: -1.5  ← Misleading! This is actually +1.5 unrest
```

**What it should say:**
```
Base Value: 10.5
From Cohesion (including discontiguity): -9.5
```

---

## Verification Matrix

| Component | Vanilla | Mod's Cohesion Patch | Mod's Unrest Patch | Status |
|-----------|---------|---------------------|-------------------|--------|
| **Cohesion Base** | 16f | Configurable ✅ | Not touched ❌ | MISMATCH |
| **Unrest Base** | 10.5f | Not touched ❌ | String replaced ⚠️ | INCONSISTENT |
| **Discontiguity in Cohesion** | N/A | Included ✅ | N/A | ✅ CORRECT |
| **Discontiguity in Unrest** | N/A | Affects via cohesion ✅ | Displayed directly ⚠️ | MISLEADING |
| **Cohesion-Unrest Relationship** | Inverse (10.5-x) | Changed ✅ | Not updated ❌ | BROKEN |

---

## Findings Summary

### ✅ What Works Correctly:
- Discontiguity malus properly affects cohesion
- Cohesion changes properly affect unrest (inverse relationship)
- Display patch correctly inserts discontiguity line

### ❌ What Has Issues:
1. **Base value relationship broken**: Cohesion base changes, but unrest base doesn't compensate
2. **Display misleading**: Shows "FromDiscontiguity" as if it's a direct unrest component
3. **String replacement logic weak**: Replacing "10.5" is cosmetic, not functional

### 🔴 Critical Issues:
- If CohesionRestStateBaseValue is changed to 18, unrest display will show "18.0" but calculation still uses 10.5
- The inverse cohesion-unrest relationship is broken when cohesion base changes
- Discontiguity display makes it seem like there are MORE unrest factors than there actually are

