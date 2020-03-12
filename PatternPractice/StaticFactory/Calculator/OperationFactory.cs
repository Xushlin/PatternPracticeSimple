namespace PatternPractice.StaticFactory.Calculator
{
    public static class OperationFactory
    {
        public static IOperation Create(string operate)
        {
            IOperation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;

            }

            return operation;
        }
    }
}
