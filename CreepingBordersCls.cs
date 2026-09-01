using HarmonyLib;
using PavonisInteractive.TerraInvicta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreepingBorders
{
    public class CreepingBordersCls
    {
        public static void Load()
        {
            var harmony = new HarmonyLib.Harmony("com.creepingborders.harmonymod");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(
        typeof(RegionControlChanged),
        MethodType.Constructor,
        new Type[]
        {
            typeof(TIRegionState),
            typeof(TINationState),
            typeof(TINationState)
        })]
    public static class RegionControlChangedPatch
    {
        [HarmonyPostfix]
        private static void Postfix()
        {
            foreach (TINationState nation1 in GameStateManager.AllExtantNations())
            {
                foreach (TIRegionState region1 in nation1.regions)
                {
                    if (region1.BorderWithAnotherNation(false))
                    {
                        foreach (TIRegionState region2 in region1.Neighbors)
                        {
                            if (region2.IsAdjacent(region1, true) && !nation1.claims.Contains(region2))
                            {
                                nation1.claims.Add(region2);
                            }
                        }
                    }

                }
                nation1.hostileClaims.Clear();

            }
        }
    }

}
