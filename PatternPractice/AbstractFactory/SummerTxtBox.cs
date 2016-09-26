using System;

namespace PatternPractice.AbstractFactory
{
    public class SummerTxtBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Summer TextBox");
        }
    }
}