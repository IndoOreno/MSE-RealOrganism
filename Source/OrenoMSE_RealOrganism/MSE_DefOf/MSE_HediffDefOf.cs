using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    [DefOf]
    public static class MSE_HediffDefOf
    {
        static MSE_HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MSE_HediffDefOf));
        }

        /* Missing Parts */
        public static HediffDef MSE_MissingMetabolismPart;

        public static HediffDef MSE_MissingEatingPart;

        public static HediffDef MSE_MissingEatingPathwayPart;

        public static HediffDef MSE_MissingBreathingPathwayPart;

        public static HediffDef MSE_MissingTalkingPart;

        public static HediffDef MSE_MissingMovingPart;

        /* Added Parts */
        public static HediffDef BionicRib;

        public static HediffDef RelaxationRib;

        public static HediffDef ArchotechRib;

        public static HediffDef AdvancedRelaxationRib;
    }
}
