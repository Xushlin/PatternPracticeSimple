using System;
using System.ComponentModel;

namespace PatternPractice.StaticFactory.Calculator
{
    [Description("1.Static Factory Calculator")]
    public class App
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number:");
            double firstNumber = Console.ReadLine().ToDouble();
            Console.WriteLine("Please enter: +,-,* or /");
            string operate = Console.ReadLine();
            Console.WriteLine("Please enter second number:");
            double secondNumber = Console.ReadLine().ToDouble();

            IOperation operation = OperationFactory.Create(operate);
            double result = operation.Calculate(firstNumber, secondNumber);

            Console.WriteLine("Result="+result);
        }
    }
}
