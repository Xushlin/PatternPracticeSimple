using System;

namespace PatternPractice.StaticFactory.Animal
{
    public class Mouse : IAnimal
    {
        public Mouse()
        {
            Console.WriteLine("Create a Mouse.");
        }
        public void Say()
        {
            Console.WriteLine("Hi,I'm a mouse! JI JI JI...");
        }
    }
}