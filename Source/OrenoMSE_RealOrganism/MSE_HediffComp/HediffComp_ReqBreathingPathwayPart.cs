using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffComp_ReqBreathingPathwayPart : HediffComp
    {
        public HediffCompProperties_ReqBreathingPathwayPart Props
        {
            get
            {
                return (HediffCompProperties_ReqBreathingPathwayPart)this.props;
            }
        }

        public override bool CompShouldRemove
        {
            get
            {
                if (Props.invert)
                {
                    return !MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.BreathingPathway);
                }
                return MSE_VanillaExtender.HasRemovedPartWithTag(parent.pawn, BodyPartTagDefOf.BreathingPathway);
            }
        }
    }
}
