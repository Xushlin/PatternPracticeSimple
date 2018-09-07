namespace PatternPractice.FactoryMethod.Structure
{
    public class ConcreteFactoryA : IFactory
    {
        public IProduct Create()
        {
            return new ConcreteProductA();
        }
    }
}