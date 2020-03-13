namespace PatternPractice.Strategy.Structure
{
    public class Context
    {
        private readonly Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
