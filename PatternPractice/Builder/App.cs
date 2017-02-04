using System;

namespace PatternPractice.Builder
{
    public static class App
    {
        public static void Execute()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===========Builder =====");
            Console.WriteLine("==============================");

            var actorController=new ActorController();
            Console.WriteLine("===========Build A Hero =====");
            var actor = actorController.Construct(new HeroBuilder());
            Console.WriteLine(actor.ToString());

            Console.WriteLine("===========Build An Angel =====");
            actor = actorController.Construct(new AngelBuilder());
            Console.WriteLine(actor.ToString());

            Console.WriteLine("===========Build A Devil =====");
            actor = actorController.Construct(new DevilBuilder());
            Console.WriteLine(actor.ToString());

            Console.WriteLine("==========Build An Angel according configuration =====");
            actor = actorController.Construct(ObjectBuildFactory<AngelBuilder>.Instance(ConfigManager.BuilderKey));
            Console.WriteLine(actor.ToString());
        }
    }
}