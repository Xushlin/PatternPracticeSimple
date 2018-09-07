using System;

namespace PatternPractice.StaticFactory.Structure
{
    public class Factory
    {
        public static IProduct Create(string productType)
        {
            IProduct product;
            switch (productType.ToUpper())
            {
                case "A":
                    product = new ConcreteProductA();
                    break;
                case "B":
                    product = new ConcreteProductB();
                    break;
                default:
                    throw new ArgumentException("Invlid Argument.", nameof(productType));
            }
            return product;
        }
    }
}