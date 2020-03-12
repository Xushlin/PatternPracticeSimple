namespace PatternPractice.StaticFactory.Calculator
{
    public class OperationAdd : IOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
