using Harmony;
using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism.Harmony
{
    public class Harmony_GetFood
    {
        [HarmonyPatch(typeof(JobGiver_GetFood))]
        [HarmonyPatch("TryGiveJob")]
        internal class GetFood_TryGiveJob
        {
            [HarmonyPrefix]
            private static bool BodiesExpander(Pawn pawn)
            {
                if (MSE_VanillaExtender.HasRemovedPartWithTag(pawn, BodyPartTagDefOf.EatingPathway))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
