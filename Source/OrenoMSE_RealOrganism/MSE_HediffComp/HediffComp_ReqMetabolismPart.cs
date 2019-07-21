using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqMetabolismPart : HediffComp
    {
        public HediffCompProperties_ReqMetabolismPart Props
        {
            get
            {
                return (HediffCompProperties_ReqMetabolismPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !(MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, MSE_BodyPartTagDefOf.MSE_MetabolismSource) || MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, BodyPartDefOf.Stomach));
                }
                return MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, MSE_BodyPartTagDefOf.MSE_MetabolismSource) || MSE_VanillaExtender.HasRemovedRequiredPart(parent.pawn, BodyPartDefOf.Stomach);
            }
        }
    }
}
