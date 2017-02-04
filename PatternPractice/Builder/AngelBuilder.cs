namespace PatternPractice.Builder
{
    public class AngelBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            Actor.Type = "Angel";
        }

        public override void BuildSex()
        {
            Actor.Sex = "Woman";
        }

        public override void BuildFace()
        {
            Actor.Face = "beautiful";
        }

        public override void BuildCostume()
        {
            Actor.Costume = "White Address";
        }

        public override void BuildHairstyle()
        {
            Actor.Hairstyle = "Long Haire";
        }
    }
}