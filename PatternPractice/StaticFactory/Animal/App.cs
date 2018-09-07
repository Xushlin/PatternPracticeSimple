using System;
using System.ComponentModel;

namespace PatternPractice.StaticFactory.Animal
{
    [Description("1.Static Factory ")]
    class App
    {
        static void Main()
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
        }
    }
}
