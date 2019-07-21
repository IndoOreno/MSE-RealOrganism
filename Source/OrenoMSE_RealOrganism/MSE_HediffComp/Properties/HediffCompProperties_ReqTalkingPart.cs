using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffCompProperties_ReqTalkingPart : HediffCompProperties
    {
        public HediffCompProperties_ReqTalkingPart()
        {
            this.compClass = typeof(HediffComp_ReqTalkingPart);
        }

        public bool invert = false;
    }
}
