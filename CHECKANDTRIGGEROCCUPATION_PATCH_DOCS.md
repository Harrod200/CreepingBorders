# CheckAndTriggerOccupation Harmony Patch

## Overview
A new Harmony prefix patch has been added to the `TIRegionState.CheckAndTriggerOccupation()` method that intercepts occupation checks and performs direct ownership transfer for annexable regions instead of going through the normal occupation process.

## Location
- **File**: `CreepingBordersCls.cs`
- **Class**: `Patch_CheckAndTriggerOccupation_AnnexableRegionTransfer`
- **Type**: Harmony Prefix Patch
- **Target**: `TIRegionState.CheckAndTriggerOccupation(TIArmyState army)`

## How It Works

### 1. **Interception Point**
The patch runs BEFORE the original `CheckAndTriggerOccupation` method. It can:
- Execute custom logic
- Return `true` to continue with the original method
- Return `false` to skip the original method entirely

### 2. **Annexable Region Detection**
```csharp
List<TIRegionState> annexableRegions = army.homeNation.AnnexableRegions();
if (annexableRegions.Contains(__instance))
```

The patch checks if the current region is in the invading nation's `AnnexableRegions` list. These are regions that are:
- Claimed by the nation
- Either contiguous with the capital OR located on an island
- Owned by a different nation

### 3. **Direct Ownership Transfer**
When a region is found to be annexable:

```csharp
previousNation.TransferRegionsControlTo(
	new List<TIRegionState> { __instance },
	occupyingNation,
	false,  // destroyArmies
	true,   // suppressReporting
	false,  // forceDecolonize
	false,  // autoTeleportArmies
	false   // skipOrgValidation
);
```

**Parameters Explained:**
- **destroyArmies**: `false` - Preserves armies in the region
- **suppressReporting**: `true` - Silently transfers without notifications
- **forceDecolonize**: `false` - Keeps colonization status
- **autoTeleportArmies**: `false` - Armies remain in place
- **skipOrgValidation**: `false` - Validates organizational changes

### 4. **Cleanup & Events**
After transfer:
```csharp
// Clear occupation values
__instance.occupations.Clear();

// Trigger region control change event
GameControl.eventManager.TriggerEvent(
	new RegionControlChanged(__instance, occupyingNation, previousNation),
	null,
	new object[] { __instance, occupyingNation, previousNation }
);
```

## Execution Flow

### **Before Patch (Normal Occupation)**
1. Army enters enemy region
2. Region occupation value increments (0 → 0.01 → 0.02 ... → 1.0)
3. Once 100% occupation reached, region transfers ownership
4. Takes multiple turns to complete

### **With Patch (Annexable Regions)**
1. Army enters annexable region
2. `CheckAndTriggerOccupation()` is called
3. **Patch intercepts and detects annexable region**
4. **Ownership transfers IMMEDIATELY** to invading nation
5. Occupation process skipped entirely
6. Returns `false` to skip original method

### **Non-Annexable Regions**
- Patch detects region is NOT annexable
- Returns `true` to continue with original method
- Normal occupation process proceeds as usual

## Conditions That Skip the Patch

The patch only activates if all conditions are met:

1. ✓ Army exists (`army != null`)
2. ✓ Army can take offensive action (`army.CanTakeOffensiveAction`)
3. ✓ Army's home nation exists (`army.homeNation != null`)
4. ✓ Region exists (`__instance != null`)
5. ✓ Region is in `AnnexableRegions` list
6. ✓ Region is owned by different nation (`previousNation != occupyingNation`)

## Benefits

### **For Creeping Borders Gameplay**
- Significantly speeds up border expansion for claimed, contiguous regions
- Eliminates multi-turn occupation for strategic annexation
- Maintains realistic borders that follow nation claims
- Preserves normal occupation mechanics for contested (non-annexable) regions

### **Island Strategy**
- Island regions (< 5 contiguous regions) transfer instantly
- Allows rapid island conquest and colonization
- Encourages multi-island nation strategies

## Edge Cases Handled

| Scenario | Behavior |
|----------|----------|
| Army has no offensive capability | Skip patch, use normal method |
| Region already owned by invading nation | Skip transfer (same owner check) |
| Region is not in annexable list | Skip patch, use normal method |
| Capital region of defending nation | Normal occupation process (parent class logic prevents capital occupation) |
| Multiple armies in region | Each activates patch independently if conditions met |

## Integration with Other Patches

This patch works alongside:
- **RegionControlChangedPatch**: Automatically claims adjacent unclaimed regions
- **Border Expansion**: Claimed regions immediately transfer
- **Normal Occupation**: Non-claimed regions still occupy normally

## Technical Notes

### **Method Signature**
```csharp
static bool Prefix(TIRegionState __instance, TIArmyState army)
```

Harmony Parameters:
- `__instance`: The region being checked for occupation
- `army`: The army triggering the occupation check

### **Return Value**
- `true`: Continue with original method (normal occupation)
- `false`: Skip original method (direct transfer completed)

### **Event Triggers**
The patch triggers the same `RegionControlChanged` event as normal occupation, ensuring all downstream systems (UI, notifications, coalitions) are properly notified.

## Performance Impact

- **Minimal**: Simple list containment check
- **Optimization**: Skips multi-turn occupation loops for contiguous regions
- **Net positive**: Reduces overall calculation time for early-game expansion

