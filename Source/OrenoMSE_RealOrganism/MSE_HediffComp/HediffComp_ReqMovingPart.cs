using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqMovingPart : HediffComp
    {
        public HediffCompProperties_ReqMovingPart Props
        {
            get
            {
                return (HediffCompProperties_ReqMovingPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.Spine);
                }
                return MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.Spine);
            }
        }
    }
}
