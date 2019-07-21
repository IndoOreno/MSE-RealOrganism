using System.Collections.Generic;
using Harmony;
using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism.Harmony
{
    public class Harmony_FoodUtility
    {
        [HarmonyPatch(typeof(FoodUtility))]
        [HarmonyPatch("ThoughtsFromIngesting")]
        internal class FoodUtility_ThoughtsFromIngesting
        {
            [HarmonyPostfix]
            private static void BodiesExpander(ref List<ThoughtDef> __result, Pawn ingester)
            {
                if (MSE_VanillaExtender.HasRemovedRequiredPart(ingester, MSE_BodyPartDefOf.Tongue))
                {
                    List<ThoughtDef> ingestThoughts = __result;
                    for (int i = 0; i < ingestThoughts.Count; i++)
                    {
                        ThoughtDef thought = ingestThoughts[i];
                        var check1 = ThoughtDefOf.AteHumanlikeMeatDirect;
                        var check2 = ThoughtDefOf.AteHumanlikeMeatDirectCannibal;
                        var check3 = ThoughtDefOf.AteInsectMeatDirect;
                        var check4 = ThoughtDefOf.AteCorpse;
                        var check5 = ThoughtDefOf.AteRottenFood;
                        if (thought != check1 || thought != check2 || thought != check3 || thought != check4 || thought != check5)
                        {
                            __result.Remove(thought);
                        }
                    }
                }
            }
        }
    }
}
