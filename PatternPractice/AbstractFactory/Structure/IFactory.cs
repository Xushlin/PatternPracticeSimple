namespace PatternPractice.AbstractFactory.Structure
{
    public interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}