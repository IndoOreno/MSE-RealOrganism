using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffCompProperties_ReqMovingPart : HediffCompProperties
    {
        public HediffCompProperties_ReqMovingPart()
        {
            this.compClass = typeof(HediffComp_ReqMovingPart);
        }

        public bool invert = false;
    }
}
