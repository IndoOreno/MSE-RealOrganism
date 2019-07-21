using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqEatingPart : HediffComp
    {
        public HediffCompProperties_ReqEatingPart Props
        {
            get
            {
                return (HediffCompProperties_ReqEatingPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, BodyPartDefOf.Jaw);
                }
                return MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, BodyPartDefOf.Jaw);
            }
        }
    }
}
