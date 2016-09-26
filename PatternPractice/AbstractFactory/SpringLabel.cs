using System;

namespace PatternPractice.AbstractFactory
{
    public class SpringLabel : ILabel
    {
        public void Disply()
        {
            Console.WriteLine("Spring Label");
        }
    }
}