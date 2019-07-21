using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    [DefOf]
    public static class MSE_BodyPartDefOf
    {
        static MSE_BodyPartDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MSE_BodyPartDefOf));
        }

        public static BodyPartDef Larynx;

        public static BodyPartDef Tongue;
    }
}
