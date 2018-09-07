using System;

namespace PatternPractice.Observe.Structure
{
    public class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("I'm Concrete Observer:)");
        }
    }
}