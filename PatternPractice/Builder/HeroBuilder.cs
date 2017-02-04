namespace PatternPractice.Builder
{
    public class HeroBuilder : ActorBuilder
    {
        public override void BuildType()
        {
            Actor.Type = "Hero";
        }

        public override void BuildSex()
        {
            Actor.Sex = "Man";
        }

        public override void BuildFace()
        {
            Actor.Face = "brilliant";
        }

        public override void BuildCostume()
        {
            Actor.Costume = "corselet";
        }

        public override void BuildHairstyle()
        {
            Actor.Hairstyle = "elegant";
        }
    }
}