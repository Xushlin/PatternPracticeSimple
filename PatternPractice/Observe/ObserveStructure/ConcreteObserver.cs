using System;

namespace PatternPractice.Observe.ObserveStructure
{
    public class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("I'm Concrete Observer:)");
        }
    }
}