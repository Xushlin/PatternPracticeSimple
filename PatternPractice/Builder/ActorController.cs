namespace PatternPractice.Builder
{
    public class ActorController
    {
        public Actor Construct(ActorBuilder actorBuilder)
        {
            actorBuilder.BuildType();
            actorBuilder.BuildSex();
            actorBuilder.BuildFace();
            actorBuilder.BuildCostume();
            actorBuilder.BuildHairstyle();

            var actor = actorBuilder.CreateActor();

            return actor;
        }
    }
}