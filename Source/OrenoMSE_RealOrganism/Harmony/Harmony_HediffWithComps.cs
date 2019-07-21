using Harmony;
using Verse;

namespace OrenoMSE_RealOrganism.Harmony
{
    public class Harmony_HediffWithComps
    {
        [HarmonyPatch(typeof(HediffWithComps))]
        [HarmonyPatch("PostAdd")]
        internal class HediffWithComps_PostAdd
        {
            [HarmonyPostfix]
            private static void BodiesExpander(HediffWithComps __instance)
            {
                MSE_VanillaExtender.BodiesExpanderSupport(__instance.pawn);
            }
        }
    }
}
