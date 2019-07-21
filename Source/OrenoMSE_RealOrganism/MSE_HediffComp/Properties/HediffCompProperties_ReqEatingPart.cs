using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffCompProperties_ReqEatingPart : HediffCompProperties
    {
        public HediffCompProperties_ReqEatingPart()
        {
            this.compClass = typeof(HediffComp_ReqEatingPart);
        }

        public bool invert = false;
    }
}
