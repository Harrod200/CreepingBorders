# Cultural Inertia (C13) — Handover Package v2

Date: 2026-10-07. Supersedes v1 for *status*; v1's mechanics sections
(§3–§9) remain normative and are unchanged. This package tells a new
instance what is DONE, what is UNTESTED, and what to do next.

## 0. Fast start (do these in order)

1. Read `Docs/Efficiency Instructions for Future Instances.md` (golden rules).
2. Run `PREFLIGHT.sh` at repo root. Build must be green before any edit.
   Build env (this VM): `export PATH=$HOME/dotnet:$PATH` and
   `export FrameworkPathOverride=$HOME/.nuget/packages/microsoft.netframework.referenceassemblies.net48/1.0.3/build/.NETFramework/v4.8/`.
3. Read `Docs/Cultural Inertia Plan.md` (rev 9) — mechanical truth.
4. Read `Cultural Inertia Handover Package v1.md` — normative design §3–§9.
5. Read this file for current status. Then read the code.
6. Search `Docs/Terra Invicta Class & Method Reference.md` (VERIFIED) before
   any decompile. NEVER trust `Terra_Invicta_Decompiled_Architecture*.md`
   (they invent method names). Decompiled source lives under
   `TI Decompiled/GameAnalysis/Assembly-CSharp/PavonisInteractive/TerraInvicta/`.

## 1. Repo state

- Git `master` @ `be0a902`, pushed to github.com/Harrod200/CreepingBorders.
- Release build: 0 errors, 1 pre-existing warning (unused `normLo`,
  GeographicPolygonMath.cs:214). DLL built and copied to
  `repo/bin/Release/CreepingBorders.dll` (95 KB). On this VM the SDK must be
  bootstrapped to `$HOME/dotnet` first (see Troubleshooting Log, environment
  notes). Build NOT yet verified in-game (no runtime testing has happened). All
  C13 code compiles but is untested in a live save.

### Pickup-session update (2026-10-07, session obu8ve)
- Two patch-time crashes fixed (see `Docs/Troubleshooting Log.md`):
  `ref bool __runOriginal` is HarmonyX-only (Lib.Harmony 2.3.6 chokes);
  `PeriodicNationUpdateTask` lives on `NationPeriodicUpdate` (Systems.PeriodicUpdates), not `TINationState`.
- Docs consolidated: single canonical `Docs/` folder; superseded handovers (v2/v3,
  old BUILD NOTES, pseudocode Implementation Plan) removed. Read order is
  Efficiency Instructions -> Plan rev 9 -> CI Handover v1 -> CI Handover v2 -> Handover Notes v5.

## 2. Implementation status vs v1 plan

| v1 plan item | Status | Where |
|---|---|---|
| Composition store + save/load + fallback | DONE | CulturalInertia.cs |
| AbsorbNation hook (culture seed on absorption) | DONE | CulturalInertia.cs :399 area |
| Unity completion hook | DONE | CulturalInertia.cs :389 area |
| Unity budgets, stance split, all-or-nothing influence | DONE | CulturalInertiaUnity.cs (405 L) |
| Outreach (focused, replacing prefix on Unity completion) | DONE | CulturalInertiaUnity.cs |
| Claims layer: conversion seeds, 30/25 hysteresis, research-grant immunity, NoHostileClaims override | DONE | CulturalInertiaClaims.cs (152 L) |
| Economy: effective-pop ×0.3/×1.3, minority malus | DONE | CulturalInertiaEconomy.cs (97 L) |
| AI: stance selection, Outreach targeting, daily tick | DONE | CulturalInertiaAI.cs (153 L) |
| Occupier-side offensive spread + ×½ strength | DONE | CulturalInertiaUnity.cs SpreadUnowned |
| Master UMM toggle `EnableCulturalInertia` gates everything | DONE | CreepingBordersCls.cs |
| Legitimise Claim policy hidden+disabled while C13 on | DONE | commit e020570; `LegitimiseClaimOption.Allowed()` → false (filters from `availableSetPolicyOptions` AND invalidates queued options) |
| UMM option "Unification Uses Current Capital" | DONE | UnificationCapitalFix.cs (independent of C13; prefix on `TINationState.MyClaimOnOtherCapital` inlining body with `originalCapital=false`) |

## 3. Session history 2026-10-07 (context)

- `54c02b1` — full C13 implementation pass (Unity/economy/AI/claims).
- `e08f3b9` — legitimised-claims persistence (RemoveHostileClaim hook +
  saved set) **REVERTED** by `e48e9f` on owner instruction. Do NOT
  re-implement; superseded by policy gating below.
- `e020570` + `5fe9290` — Legitimise Claim policy hidden/disabled when C13
  is enabled. This is the intended design (organic conversion only).
- `58c3b24` — docs: vanilla unification map in Handover Notes v5 appendix
  (verified: eligibility gating, capital-claim check, AbsorbNation chain,
  50% priority-investment transfer, breakaway parent/child exempt from
  capital-claim check).
- `be0a902` — UMM option to make unification check CURRENT capital instead
  of original.

## 4. Key technical facts (verified, do not re-derive)

- `MyClaimOnOtherCapital(target, originalCapital, includeHostile)` —
  TINationState.cs:6871. Hostile claims never satisfy unification unless
  `includeHostile`. `prohibitCapitalShenanigans` (global template) selects
  original vs current capital at call sites; the mod's prefix bypasses it.
- Unification chain: `UnificationOption` (Allowed = ExecutivePowerConsolidated,
  targets = `eligibleUnifications` @ TINationState.cs:6706) →
  `Unification()` :9908 → `AbsorbNation` :9801. Hook AbsorbNation, NOT
  Unification — narrative effects (TIEffectsState.cs:3056/3069) and
  AnnexNation also reach AbsorbNation.
- RemoveHostileClaim postfix was the WRONG hook for persistence and is gone.
- Policy option gating: returning false from `Allowed()` hides the option
  from `availableSetPolicyOptions` and also invalidates queued options
  (checked again at execution).
- No border/ideological-distance conditions in `eligibleUnifications` —
  only federation-claim, executive-faction equality, war state.

## 5. What is NOT done / next steps

1. **In-game verification (highest priority).** Nothing has been run in
   Terra Invicta. Suggested checks: fresh save with C13 on; verify
   composition store persists across save/load; Unity completion produces
   defensive spreads; Outreach fires and pays influence; hysteresis
   promotes/demotes claims; Legitimise Claim policy absent from list;
   unification with destroyed original capital succeeds when option on.
2. v1 §3 mechanics 7–8 (effective-pop tables) — economy layer is minimal;
   cross-check against the full table list in the Plan before extending.
3. Numbers tuning — all defaults from v1 §5 are first-pass; expect a
   balance pass after playtesting.
4. Non-scope reminders (v1 §9) still hold: C3 verify, C4, C5,
   HostileClaimsBlockCreep (D44), policy refactor, map-data questions.

## 6. Working rules (unchanged, from core memory)

- Reference assembly first; decompiled code only as last resort.
- Source of truth: v1 package for scope/questions; Plan rev 9 for
  mechanics. Earlier docs and chat history are NOT authoritative.
- Scope is C13 only.
- PREFLIGHT.sh patched wget→curl locally (VM has no wget); pushes happen
  from the owner machine (a PAT was provided in-session; never store it).
