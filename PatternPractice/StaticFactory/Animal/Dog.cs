using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Dog : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Hi,I'm a dog!");
        }
    }
}