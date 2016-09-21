using System;

namespace PatternPractice.StaticFactory.Animal
{
    public static class App
    {
        public static void Execute()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===========Static Factory=====");
            Console.WriteLine("==============================");
            IAnimal animal = null;

            animal = AnimalFactory.CreateAnimal(AnimalType.Cat);
            animal.Say();

            animal = AnimalFactory.CreateAnimal(AnimalType.Dog);
            animal.Say();

            animal = AnimalFactory.CreateAnimal(AnimalType.Mouse);
            animal.Say();
            Console.ReadKey();
        }
    }
}
