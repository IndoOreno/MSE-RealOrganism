using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    [DefOf]
    public static class MSE_BodyPartTagDefOf
    {
        static MSE_BodyPartTagDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MSE_BodyPartTagDefOf));
        }

        public static BodyPartTagDef MSE_MetabolismSource;
    }
}
