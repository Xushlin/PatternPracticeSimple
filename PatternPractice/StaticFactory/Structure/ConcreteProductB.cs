using System;

namespace PatternPractice.StaticFactory.Structure
{
    public class ConcreteProductB : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("I am product B");
        }
    }
}