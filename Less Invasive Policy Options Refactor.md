# CreepingBorders — Less-Invasive Policy Options (Refactor Proposal)

Status: **proposal, ready to apply to GitHub master after a fresh pull.**
Deliberately NOT applied to the bundled snapshot (`CreepingBordersCls.cs`) — the handover
notes warn that the snapshot is pre-fix and diverging from master causes silent conflicts.
The PAT in the notes returns 401, so master could not be fetched from this machine.

## The change in one paragraph

Delete the entire `Patch_NotificationScreenController_PopulatePolicyOptions` class
(~245 lines of reflection-driven UI surgery) and replace it with a ~30-line postfix on
`TINationState.availableSetPolicyOptions(bool)`. The vanilla
`NotificationScreenController.PopulatePolicyOptions` already sizes the list and calls
`PolicyListItemController.SetListItem(...)` for every option that method returns, so the
game does all the UI wiring itself. Both new options (Set Capital, Legitimise Claim)
flow through the same code path as every vanilla policy.

## Why this is less invasive

| | Current approach | Proposed approach |
|---|---|---|
| Patched method | `NotificationScreenController.PopulatePolicyOptions` (UI internals) | `TINationState.availableSetPolicyOptions` (data source) |
| Reflection | 5 fields/methods incl. generic `MakeGenericMethod` on `SetListSize<T>` | none |
| List resizing | manual `SetListSize(size+1)` + enumerator walk per option | automatic |
| Alternation bug (options appearing every other time) | root cause is double manual resizing | eliminated (never touches the list) |
| Fragility | breaks if game renames any UI field | breaks only if the game changes the policy *system* |
| Lines of patch code | ~245 | ~30 |

## Verified against the decompiled docs in this package

- `NotificationScreenController` exposes `currentNation` (private) and
  `policyOptionsList` (public `ListManagerBase`); `PopulatePolicyOptions()` and
  `PolicySelected(TIPolicyOption)` are its policy-menu methods.
- `TINationState.availableSetPolicyOptions(bool includeCancel)` returns
  `List<TIPolicyOption>` (line 1762 of `TINationState.md`).
- `ListManagerBase.SetListSize<T>(int, bool, bool)` exists and is generic — which is
  exactly why the current code needs `MakeGenericMethod`; the vanilla path never does.
- `PolicyListItemController.SetListItem(controller, TIPolicyOption, TINationState)` is
  the per-item wiring the vanilla loop already performs.

## Code to apply

### 1. Add this patch (e.g. right after the existing `Patch_BuildRegionDataTooltip` class)

```csharp
    // ====================================================================
    // HARMONY PATCH - POLICY OPTION REGISTRATION (data source, not UI)
    // ====================================================================

    /// <summary>
    /// Appends the mod's policy options to the nation's list of settable
    /// policy options. NotificationScreenController.PopulatePolicyOptions
    /// iterates this list and wires up the UI itself, so no UI code is
    /// touched at all.
    /// </summary>
    [HarmonyPatch(typeof(TINationState), "availableSetPolicyOptions")]
    public static class Patch_AvailableSetPolicyOptions
    {
        static void Postfix(TINationState __instance, bool includeCancel, ref List<TIPolicyOption> __result)
        {
            try
            {
                if (__instance == null || __result == null)
                    return;

                var setCapital = new SetCapitalOption();
                if (setCapital.Allowed(__instance))
                    __result.Add(setCapital);

                var legitimise = new LegitimiseClaimOption();
                if (legitimise.Allowed(__instance))
                    __result.Add(legitimise);
            }
            catch (Exception ex)
            {
                CreepingBordersCls.mod.Logger.Error($"[PolicyRegistration] ERROR appending options: {ex.Message}");
            }
        }
    }
```

### 2. Delete this block entirely

`Patch_NotificationScreenController_PopulatePolicyOptions` — everything from the
`[HarmonyPatch(typeof(NotificationScreenController), "PopulatePolicyOptions")]`
attribute down to the class's closing brace (currently ~line 2414–2657 in the
snapshot; find the equivalent block in master).

### 3. Rename the option classes (optional but recommended)

- `RegionSelectorPlaceholder` → `SetCapitalOption` (the name above already assumes this).
- Keep `LegitimiseClaimOption` as is.

## Risks and things to verify in-game

1. **`PolicyType` collision.** Both options return `PolicyType.CancelOption` as a
   placeholder. `PolicySelected(TIPolicyOption)` in the controller may consult
   `GetPolicyType()` when routing the mission/confirm flow. If "Set Capital" gets
   routed through the cancel path, try reusing an existing low-traffic type that takes
   a region target, or keep CancelOption and confirm behaviour in a test save.
2. **`new` vs `override`.** `TIPolicyOption.GetDisplayName()` is **not virtual** in the
   decompile, so `public new` is the only option for those string getters. This means
   anything holding the instance as `TIPolicyOption` calls the *base* display text.
   Vanilla's own options override things like `GetPossibleTargets`/`OnPassage`
   (abstract — safe), but the menu label may come from `templateName()` instead.
   Check which string actually shows in the policy list after the refactor; if the
   label is wrong, the fix is inside `templateName()` or a Loc key, not more patches.
3. **AI safety.** `Importance(...)` returns 0 and the options are not registered in
   `PolicyManager.policies`, so the AI council should never pick them. Re-verify after
   refactor (the postfix only touches the *player-facing* list returned by
   `availableSetPolicyOptions` — if the AI calls the same method, the
   `Allowed()`/`Importance()==0` gating plus vanilla mission-goal logic is what keeps
   the AI from using it; watch one AI turn cycle in a test save).
4. **`RequiresTargets()` / `GetPossibleTargets()`.** Both are already overridden
   correctly in the snapshot's option classes; no change needed.
5. **Influence cost.** The three commits from the handover (a92417b, e997aa0, 66e2302)
   moved `INFLUENCE_COST` to a shared field and added gating — ensure master has these
   before applying, since this proposal was written against a snapshot that predates them.

## Test checklist after applying

- [ ] Policy menu opens with both new options listed every time (run 5+ opens).
- [ ] Set Capital on a non-capital region moves the capital; on the capital it's a no-op.
- [ ] Legitimise Claim only lists claims the nation holds on other nations.
- [ ] Influence is deducted exactly once per enactment.
- [ ] AI councilors never enact either option over a full in-game year.
- [ ] Cancel option still works from the same menu.
