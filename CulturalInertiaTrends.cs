using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using PavonisInteractive.TerraInvicta.Systems.PeriodicUpdates;

namespace CreepingBorders
{
    /// <summary>
    /// C13 cultural trend history — rolling daily snapshots of each region's
    /// culture composition, powering the tooltip's 31-day trend display.
    ///
    /// Sampled once per campaign day via a postfix on
    /// FactionPeriodicUpdate.OnDaily0000Update (the game's daily tick). History
    /// is in-memory only; it is NOT persisted, so a trend needs up to 31
    /// in-game days to fully (re)build after loading a save. Trends with fewer
    /// than two samples report no delta rather than guessing.
    ///
    /// Day indexing: OnDaily0000Update increments daysInCampaign BEFORE
    /// FactionOperations0000 runs, so a postfix sample always sees the new day
    /// number — one sample per day, monotonically increasing.
    /// </summary>
    public static class CulturalInertiaTrends
    {
        private class Snapshot
        {
            public int day;
            public Dictionary<string, float> comp;
        }

        private static readonly Dictionary<string, List<Snapshot>> history =
            new Dictionary<string, List<Snapshot>>();

        private const int MaxSamples = 31;

        private static readonly Dictionary<string, string> nameCache =
            new Dictionary<string, string>();

        // ==================================================================
        // DAILY SAMPLER
        // ==================================================================

        [HarmonyPatch(typeof(FactionPeriodicUpdate), "OnDaily0000Update")]
        private static class Patch_OnDaily0000Update
        {
            static void Postfix()
            {
                try
                {
                    if (!CulturalInertia.Enabled) return;
                    SampleAll();
                }
                catch (Exception ex)
                {
                    CreepingBordersCls.mod?.Logger.Error(
                        $"[CulturalInertia] Trend sample error: {ex.Message}");
                }
            }
        }

        private static void SampleAll()
        {
            int day = GameStateManager.Time().daysInCampaign;
            foreach (var region in GameStateManager.AllRegions())
            {
                if (region == null) continue;
                var comp = CulturalInertia.Composition(region);
                if (comp == null || comp.Count == 0) continue;

                var key = region.ID.ToString();
                if (!history.TryGetValue(key, out var list))
                {
                    list = new List<Snapshot>();
                    history[key] = list;
                }
                // Skip double-sampling the same day (safety net).
                if (list.Count > 0 && list[list.Count - 1].day == day) continue;
                list.Add(new Snapshot { day = day, comp = new Dictionary<string, float>(comp) });
                if (list.Count > MaxSamples) list.RemoveAt(0);
            }
        }

        /// <summary>Clears trend history (on returning to the main menu).</summary>
        public static void ResetInMemoryState()
        {
            history.Clear();
        }

        // ==================================================================
        // QUERIES
        // ==================================================================

        /// <summary>
        /// Trend for one culture in one region: current share and the change
        /// over the sampled window (up to 31 days). Returns false when there
        /// is not yet enough history for a delta.
        /// </summary>
        public static bool Trend(
            TIRegionState region, string culture, out float current, out float delta)
        {
            current = 0f;
            delta = 0f;
            if (region == null || string.IsNullOrEmpty(culture)) return false;
            if (!history.TryGetValue(region.ID.ToString(), out var list) || list.Count == 0)
                return false;

            var latest = list[list.Count - 1];
            if (!latest.comp.TryGetValue(culture, out current))
                current = 0f;

            if (list.Count < 2) return false;

            // Earliest sample within the trailing 31 days (day is monotonic).
            Snapshot earliest = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (latest.day - list[i].day > MaxSamples - 1) continue;
                earliest = list[i];
                break;
            }
            if (earliest == null || earliest.day == latest.day) return false;

            delta = current - (earliest.comp.TryGetValue(culture, out var then) ? then : 0f);
            return true;
        }

        /// <summary>
        /// All cultures currently affecting a region (the live composition),
        /// sorted by share descending. Current values are read from the live
        /// composition, not the snapshot, so the tooltip never lags a tick.
        /// </summary>
        public static List<KeyValuePair<string, float>> CurrentCultures(TIRegionState region)
        {
            if (region == null) return new List<KeyValuePair<string, float>>();
            var comp = CulturalInertia.Composition(region);
            if (comp == null) return new List<KeyValuePair<string, float>>();
            return comp.OrderByDescending(kv => kv.Value).ToList();
        }

        /// <summary>
        /// Human-readable culture name: cultures are keyed by owning-nation ID,
        /// so map to the nation's display name (cached). Falls back to the raw
        /// id when no matching nation exists (e.g. "unassigned").
        /// </summary>
        public static string DisplayName(string cultureId)
        {
            if (string.IsNullOrEmpty(cultureId)) return cultureId;
            if (nameCache.TryGetValue(cultureId, out var name)) return name;
            name = cultureId;
            try
            {
                if (cultureId == "unassigned")
                {
                    name = Loc.T("UI.Nation.Culture.Unassigned");
                }
                else
                {
                    var nation = GameStateManager.AllNations()
                        .FirstOrDefault(x => x != null && x.ID.ToString() == cultureId);
                    if (nation != null) name = nation.displayNameWithArticle;
                }
            }
            catch (Exception) { /* leave raw id */ }
            nameCache[cultureId] = name;
            return name;
        }
    }
}
