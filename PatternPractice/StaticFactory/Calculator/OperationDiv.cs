using System;

namespace PatternPractice.StaticFactory.Calculator
{
    public class OperationDiv : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0) throw new DivideByZeroException("second number should not be 0.");

            return firstNumber / secondNumber;
        }
    }
}
