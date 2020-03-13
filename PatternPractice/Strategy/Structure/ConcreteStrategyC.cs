using System;

namespace PatternPractice.Strategy.Structure
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(nameof(ConcreteStrategyC));
        }
    }
}
