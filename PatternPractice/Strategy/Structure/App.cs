using System.ComponentModel;

namespace PatternPractice.Strategy.Structure
{
    [Description("Strategy")]
    public class App
    {
        public static void Main()
        {
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}
