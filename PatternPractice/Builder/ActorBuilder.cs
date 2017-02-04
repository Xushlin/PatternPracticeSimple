namespace PatternPractice.Builder
{
    public abstract class ActorBuilder
    {
        protected Actor Actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();

        public Actor CreateActor()
        {
            return Actor;
        }
    }
}