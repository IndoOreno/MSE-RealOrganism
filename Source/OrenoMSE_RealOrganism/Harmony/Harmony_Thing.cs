using Harmony;
using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism.Harmony
{
    public class Harmony_Thing
    {
        [HarmonyPatch(typeof(Thing))]
        [HarmonyPatch("Ingested")]
        internal class Thing_Ingested
        {
            [HarmonyPostfix]
            private static void BodiesExpander(ref float __result, Pawn ingester)
            {
                if (MSE_VanillaExtender.HasRemovedPartWithTag(ingester, BodyPartTagDefOf.EatingPathway))
                {
                    __result = 0f;
                }
            }
        }
    }
}
