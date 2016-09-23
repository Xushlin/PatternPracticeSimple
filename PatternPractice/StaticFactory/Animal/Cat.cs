using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Cat : IAnimal
    {
        public Cat()
        {
            Console.WriteLine("Create a Cat.");
        }
        public void Say()
        {
            Console.WriteLine("Hi,I'm a cat!, MI MI MI...");
        }
    }
}
