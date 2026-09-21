
## Amendment: independence-granted nations treated as breakaways (09:35)
- User amended C6 and C8. Scope: nations released by the "grant independence" national policy (vanilla `PeacefulBreakupOption`) get breakaway treatment for cultural mismatch for 2 years.
- Vanilla recon: `PeacefulBreakupOption.OnPassage` has two paths — `ReleaseBreakaway(amicable:true)` for existing breakaways and `ReleaseNation` for reviving defunct nations. `ReleaseNation` doesn't touch `breakawayParent`; `ReleaseBreakaway` clears it, and `breakaway` is a derived property (`breakawayParent != null`). A flag-based relief would therefore vanish at grant → relief must be a timestamp (e.g. `culturalReliefUntil`), written at both release paths. Only time-based calcs to reuse: the international-relations cooldowns pattern.
- C8 amendment: released regions get the 50/50 spawn blend at grant, same as breakaway formation. This extends the sanctioned special-case seed list (breakaway formation + recognised absorption → + independence grant).
- DECISION (flagged for user): read the amendment as the full breakaway treatment — both the C6 relief (2-year expiry) and the C8 50/50 spawn blend — applied at grant. If only the relief was intended, C8's amendment should be cut back.
- Both edits written into Handover Notes v3.md; implementation notes added (no code yet).

## Amendment refinement: three release categories (09:40)
- User confirmed the full-treatment reading and sharpened the taxonomy: rebel breakaways, recognised breakaways, and peaceful breakups are distinct.
  - **Rebel breakaways** (`breakawayParent != null`): permanent ×0.5 relief, no expiry.
  - **Recognised breakaways** (released via amicable `ReleaseBreakaway`): 2-year grace, then full malus.
  - **Peaceful breakups / independence grants** (`ReleaseNation` revival path): 2-year grace, then full malus.
- Implementation note: the amicable path *clears* `breakawayParent` in the same call — stamp `culturalReliefUntil` there, otherwise the nation silently loses rebel relief and gains nothing. `ReleaseNation` never sets `breakawayParent`, so it stamps unconditionally.
- C6 and C8 rewritten in Handover Notes v3.md (second-pass amendments); prior single-pass wording superseded.

## Handover notes updated; git push blocked (09:42)
- Handover Notes v3.md updated with: C2 bake results + validations, C6/C8 amendments (final two-tier wording), session-log pointer, revised credit estimate.
- **BLOCKED on git push**: no `.git` in the working copy (upstream clone dir has none either) and no configured remote/credentials in this VM. v2 notes reference `Harrod200/CreepingBorders` master and "a fresh PAT worked" — the PAT is not stored here. Owner action: either `git init` + add remote `https://github.com/Harrod200/CreepingBorders.git` and provide a PAT, or push from the owner's own machine using this folder. Nothing has been committed here; the folder contents are push-ready as a snapshot.

## Session 5 (2026-09-21 PM) — contiguity spec locked, no code changes

- Locked the contiguity behaviours through five rapid amendments (PC-from-island
  ban → FC-island bridge with PC ban → island-gated distance → allied-nation
  degradation → island-internal seed rule → no BFS-PC upgrade via bridge).
- Claim-creep source gating added to the plan as a sub-option
  (`HostileClaimsBlockCreep`, default enabled): seed only from
  `nonHostileClaims`. Canonical A1/B1–B3 example recorded.
- Top-to-tail mod summary produced; open questions reviewed — the two blockers
  (X value, island designation) remain owner-decisions.
- Infra: git history recovered via rebase onto origin/master (PAT push);
  repo relocated to /rool-drive/CB/repo; efficiency instructions amended to
  mandate /rool-drive/CB; docs commits 38aeada, 75045e6 pushed.
- Package re-zipped as v5 with all of the above.

## Session 6 (2026-09-21 evening) — C2 revision, absorption removal, patch fixes; C11 spec only

- C2 revised: flat 0.5% assimilation per Unity completion, slider renamed (b7e4217).
- Absorption culture mechanic removed entirely; AbsorptionRecognitionRate gone (f3dff60); stale UI label fixed later (83213a0).
- Fixed duplicated/stranded C8/C9/C10 patch classes in CulturalInertia.cs — block was outside namespace and missing its closing brace; would not have compiled (1aa7e1e).
- C6–C10 patches verified present, build green.
- C11 (Cultural Outreach policy): spec researched (registration pattern, Loc keys, influence payment, adjacency-based targeting, RequiresTargetConfirm vs WithConfirm distinction) but NO code written — session ended. Next instance starts with C11 implementation, ~120 credits.
- Handover Notes updated to v6; package re-zipped.
