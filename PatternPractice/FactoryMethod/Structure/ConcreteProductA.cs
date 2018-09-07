using System;

namespace PatternPractice.FactoryMethod.Structure
{
    public class ConcreteProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("I'm Product A");
        }
    }
}