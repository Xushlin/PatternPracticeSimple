using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Mouse : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Hi,I'm a mouse!");
        }
    }
}