namespace PatternPractice.Builder
{
    public class DevilBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            Actor.Type = "Devil";
        }

        public override void BuildSex()
        {
            Actor.Sex = "Man";
        }

        public override void BuildFace()
        {
            Actor.Face = "ugliness";
        }

        public override void BuildCostume()
        {
            Actor.Costume = "guard of palace";
        }

        public override void BuildHairstyle()
        {
            Actor.Hairstyle = "bareheaded";
        }
    }
}