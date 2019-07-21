using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqTalkingPart : HediffComp
    {
        public HediffCompProperties_ReqTalkingPart Props
        {
            get
            {
                return (HediffCompProperties_ReqTalkingPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, MSE_BodyPartDefOf.Larynx);
                }
                return MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, MSE_BodyPartDefOf.Larynx);
            }
        }
    }
}
