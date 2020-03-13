using System;

namespace PatternPractice.Strategy.Structure
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(nameof(ConcreteStrategyA));
        }
    }
}
