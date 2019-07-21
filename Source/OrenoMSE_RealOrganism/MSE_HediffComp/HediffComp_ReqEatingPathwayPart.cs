using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqEatingPathwayPart : HediffComp
    {
        public HediffCompProperties_ReqEatingPathwayPart Props
        {
            get
            {
                return (HediffCompProperties_ReqEatingPathwayPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.EatingPathway);
                }
                return MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.EatingPathway);
            }
        }
    }
}
