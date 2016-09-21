using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Cat : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Hi,I'm a cat!");
        }
    }
}
