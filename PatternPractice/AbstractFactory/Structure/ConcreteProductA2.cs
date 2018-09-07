using System;

namespace PatternPractice.AbstractFactory.Structure
{
    public class ConcreteProductA2 : IProductA
    {
        public void DoSomething()
        {
            Console.WriteLine("Hi I'm ProductA2");
        }
    }
}