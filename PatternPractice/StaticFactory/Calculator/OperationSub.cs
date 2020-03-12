namespace PatternPractice.StaticFactory.Calculator
{
    public class OperationSub : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
