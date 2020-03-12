namespace PatternPractice.StaticFactory.Calculator
{
    public class OperationMul : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
