namespace PatternPractice.FactoryMethod.Structure
{
    public class ConcreteFactoryB : IFactory
    {
        public IProduct Create()
        {
            return new ConcreteProductB();
        }
    }
}