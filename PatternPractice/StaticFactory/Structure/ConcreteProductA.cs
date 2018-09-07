using System;

namespace PatternPractice.StaticFactory.Structure
{
    public class ConcreteProductA : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("I am product A");
        }
    }
}