using Verse;

namespace OrenoMSE_RealOrganism
{
    public class HediffCompProperties_ReqMetabolismPart : HediffCompProperties
    {
        public HediffCompProperties_ReqMetabolismPart()
        {
            this.compClass = typeof(HediffComp_ReqMetabolismPart);
        }

        public bool invert = false;
    }
}
