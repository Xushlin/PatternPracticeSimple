using System;

namespace PatternPractice.FactoryMethod.Structure
{
    public class ConcreteProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("I'm Product B");
        }
    }
}