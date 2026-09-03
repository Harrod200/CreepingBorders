# Testing NoDistanceCohesionMalus In-Game

## Quick Test Steps

### Step 1: Enable the Mod and Load a Game
1. Launch Terra Invicta with CreepingBorders mod enabled
2. Load or create a game
3. Select a nation with multiple regions spread far apart (e.g., US spread across North America, or China with distant claims)

### Step 2: Check Cohesion Display
1. Open Nation Info panel (click on your nation name)
2. Look at the "Cohesion" section
3. Click to expand the breakdown details

### Step 3: Test with NoDistanceCohesionMalus = TRUE (Default)

**Before**: Should NOT see "FromRegions" or geographic distance penalty in the breakdown

**Expected UI Display**:
```
=== Cohesion Rest State Breakdown ===
Base Value: [Your configured value, default 16.0]
From Inequality: [value]
From Low PC-GDP: [value]
From Population: [value]
(NO "From Regions" / "FromRegions" line)
From Hostile Claims: [value]
... other factors ...
```

**Expected Cohesion**: Relatively high despite geographic spread

### Step 4: Toggle Setting to FALSE and Reload

1. Press ESC to open mod settings
2. Find "No Distance Cohesion Malus" toggle
3. **Disable it** (set to FALSE)
4. Reload the save (quicksave/quickload or close and reopen)

### Step 5: Test with NoDistanceCohesionMalus = FALSE

**Now should see**: "From Regions" or geographic distance penalty in the breakdown

**Expected UI Display**:
```
=== Cohesion Rest State Breakdown ===
Base Value: [Your configured value, default 16.0]
From Inequality: [value]
From Low PC-GDP: [value]
From Population: [value]
From Regions: [NEGATIVE VALUE]    ← THIS NOW APPEARS
From Hostile Claims: [value]
... other factors ...
```

**Expected Cohesion**: Should be lower than when the setting was TRUE

### Step 6: Verify the Difference

**Compare the two cohesion values:**
- With `NoDistanceCohesionMalus = true`: Higher cohesion
- With `NoDistanceCohesionMalus = false`: Lower cohesion (vanilla behavior)

**The difference should be approximately the vanilla "From Regions" penalty** (typically -1 to -7.5)

---

## Verification Criteria

✅ **Test Passes If:**
- When TRUE: No "From Regions" line in cohesion breakdown
- When FALSE: "From Regions" line appears with negative value
- Cohesion is noticeably higher when TRUE vs FALSE
- Toggling the setting changes cohesion immediately after reload

❌ **Test Fails If:**
- Setting has no effect on cohesion
- "From Regions" always appears regardless of setting
- No difference in cohesion values between TRUE and FALSE
- Cohesion values don't update when toggling

---

## Advanced Debug: Check Unrest Impact

The `NoDistanceCohesionMalus` setting affects cohesion, which inversely affects unrest.

**Expected unrest behavior:**
- When `NoDistanceCohesionMalus = true`: Lower unrest (higher cohesion)
- When `NoDistanceCohesionMalus = false`: Higher unrest (lower cohesion)

**To verify:**
1. Check Nation Info → Unrest section
2. Toggle `NoDistanceCohesionMalus` on/off
3. Observe that unrest changes inversely to cohesion

---

## Troubleshooting

### Setting doesn't appear to work?
- **Check**: Is the mod loaded? (Look for "[CreepingBorders]" in the log)
- **Check**: Did you reload the save after changing the setting?
- **Check**: Is the cohesion UI panel actually showing "From Regions" when FALSE?

### "From Regions" never appears?
- **Possible cause**: Your nation isn't spread far enough geographically
- **Solution**: Select a nation with 3+ regions far apart, or test with a nation that definitely has geographic spread

### Cohesion values look different from vanilla?
- **Possible cause**: Your `CohesionRestStateBaseValue` is different from default (16.0)
- **Verify**: Check the mod settings - what is the base value set to?
- **Note**: The setting modifies the BASE VALUE independently, so cohesion will differ even when `NoDistanceCohesionMalus = false` if you changed the base

### Can't find mod settings?
- **Standard location**: Press ESC during gameplay → Look for "Creeping Borders Settings" in the mod manager panel
- **Alternate**: Settings may be saved to `Mods/Enabled/CreepingBorders/settings.json`

---

## Expected Values Reference

For a typical mid-game nation spread 2,000-3,000 km:

| Setting | Expected "From Regions" | Expected Cohesion Impact |
|---------|------------------------|--------------------------|
| `true` (disabled penalty) | (not shown) | +5 to +7.5 higher |
| `false` (enabled penalty) | -5.0 to -7.5 | Normal vanilla penalty |

**Example with base value 16.0:**
- TRUE: Cohesion rest state ≈ 8-10 (without distance penalty)
- FALSE: Cohesion rest state ≈ 0-3 (with -7.5 distance penalty + other factors)

---

## Success Indicator

🎯 **You'll know it's working when:**
- Enabling the setting makes geographically spread nations viable
- Disabling it brings back the vanilla "don't spread too far" limitation
- The cohesion breakdown UI shows/hides the distance penalty based on the setting
