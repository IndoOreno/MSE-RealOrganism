using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffCompProperties_ReqEatingPathwayPart : HediffCompProperties
    {
        public HediffCompProperties_ReqEatingPathwayPart()
        {
            this.compClass = typeof(HediffComp_ReqEatingPathwayPart);
        }

        public bool invert = false;
    }
}
