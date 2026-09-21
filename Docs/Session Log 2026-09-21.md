
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
