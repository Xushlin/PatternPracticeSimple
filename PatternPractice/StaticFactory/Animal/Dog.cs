using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            Console.WriteLine("Create a Dog.");
        }
        public void Say()
        {
            Console.WriteLine("Hi,I'm a dog! WANG WANG WANG...");
        }
    }
}