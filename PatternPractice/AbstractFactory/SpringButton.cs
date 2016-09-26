using System;

namespace PatternPractice.AbstractFactory
{
    public class SpringButton : IButton
    {
        public void Disply()
        {
            Console.WriteLine("Spring button.");
        }
    }
}