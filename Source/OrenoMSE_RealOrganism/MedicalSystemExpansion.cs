using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Harmony;
using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    [StaticConstructorOnStartup]
    public class MedicalSystemExpansion
    {
        static MedicalSystemExpansion()
        {
            var harmony = HarmonyInstance.Create("OrenoMSE_RealOrganism");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    public static class MSE_VanillaExtender
    {
        public static bool HasRemovedPartWithTag(Pawn pawn, BodyPartTagDef tag)
        {
            List<BodyPartRecord> AllParts = pawn.RaceProps.body.AllParts;
            for (int i = 0; i < AllParts.Count; i++)
            {
                BodyPartRecord part = pawn.RaceProps.body.AllParts[i];
                if (part.def.tags.Contains(tag) && pawn.health.hediffSet.GetPartHealth(part) == 0f && part != pawn.RaceProps.body.corePart)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasRemovedRequiredPart(Pawn pawn, BodyPartDef part)
        {
            List<BodyPartRecord> AllParts = pawn.RaceProps.body.AllParts;
            bool IsRemovedParts = AllParts.Where(parts => parts.def == part)
                .All(parts => pawn.health.hediffSet.GetPartHealth(parts) == 0f);
            for (int i = 0; i < AllParts.Count; i++)
            {
                BodyPartRecord record = pawn.RaceProps.body.AllParts[i];
                if (record != null && record.def == part && IsRemovedParts && record != pawn.RaceProps.body.corePart)
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountAddedParts(HediffSet hs, HediffDef ap)
        {
            int num = 0;
            List<Hediff> hediffs = hs.hediffs;
            for (int i = 0; i < hediffs.Count; i++)
            {
                if (hediffs[i].def == ap)
                {
                    num++;
                }
            }
            return num;
        }

        public static void BodiesExpanderSupport(Pawn pawn)
        {
            if (pawn.health.capacities.CapableOf(PawnCapacityDefOf.Eating))
            {
                if (pawn.health.capacities.CapableOf(PawnCapacityDefOf.Metabolism))
                {
                    bool metabolismPart1 = HasRemovedPartWithTag(pawn, MSE_BodyPartTagDefOf.MSE_MetabolismSource);
                    bool metabolismPart2 = HasRemovedRequiredPart(pawn, BodyPartDefOf.Stomach);
                    if ((metabolismPart1 || metabolismPart2) && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingMetabolismPart))
                    {
                        Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingMetabolismPart, pawn, null);
                        pawn.health.AddHediff(hediff, null, null, null);
                    }
                }

                bool eatingPart = HasRemovedRequiredPart(pawn, BodyPartDefOf.Jaw);
                if (eatingPart && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingEatingPart))
                {
                    Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingEatingPart, pawn, null);
                    pawn.health.AddHediff(hediff, null, null, null);
                }

                bool eatingPathwayPart = HasRemovedPartWithTag(pawn, BodyPartTagDefOf.EatingPathway);
                if (eatingPathwayPart && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingEatingPathwayPart))
                {
                    Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingEatingPathwayPart, pawn, null);
                    pawn.health.AddHediff(hediff, null, null, null);
                }
            }

            if (pawn.health.capacities.CapableOf(PawnCapacityDefOf.Breathing))
            {
                bool breathingPathwayPart = HasRemovedPartWithTag(pawn, BodyPartTagDefOf.BreathingPathway);
                if (breathingPathwayPart && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingBreathingPathwayPart))
                {
                    Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingBreathingPathwayPart, pawn, null);
                    pawn.health.AddHediff(hediff, null, null, null);
                }
            }

            if (pawn.health.capacities.CapableOf(PawnCapacityDefOf.Talking))
            {
                bool talkingPart = HasRemovedRequiredPart(pawn, MSE_BodyPartDefOf.Larynx);
                if (talkingPart && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingTalkingPart))
                {
                    Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingTalkingPart, pawn, null);
                    pawn.health.AddHediff(hediff, null, null, null);
                }
            }

            if (pawn.health.capacities.CapableOf(PawnCapacityDefOf.Moving))
            {
                bool movingPart = HasRemovedPartWithTag(pawn, BodyPartTagDefOf.Spine);
                if (movingPart && !pawn.health.hediffSet.HasHediff(MSE_HediffDefOf.MSE_MissingMovingPart))
                {
                    Hediff hediff = HediffMaker.MakeHediff(MSE_HediffDefOf.MSE_MissingMovingPart, pawn, null);
                    pawn.health.AddHediff(hediff, null, null, null);
                }
            }
        }
    }
}
