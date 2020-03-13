using System;

namespace PatternPractice.Strategy.Structure
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(nameof(ConcreteStrategyB));
        }
    }
}
