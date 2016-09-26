using System;

namespace PatternPractice.AbstractFactory
{
    public  class SummerButton : IButton
    {
        public void Disply()
        {
            Console.WriteLine("Summer button.");
        }
    }
}