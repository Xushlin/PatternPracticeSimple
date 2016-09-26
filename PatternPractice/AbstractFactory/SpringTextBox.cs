using System;

namespace PatternPractice.AbstractFactory
{
    public class SpringTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Spring TextBox");
        }
    }
}