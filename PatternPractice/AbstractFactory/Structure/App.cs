using System;
using System.ComponentModel;

namespace PatternPractice.AbstractFactory.Structure
{
    [Description("3.0 Abstract factory structure.")]
    public class App
    {
        static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("==Abstract Factory Structure==");
            Console.WriteLine("==============================");

            Console.WriteLine("Create FactoryA Instance");
            IFactory factory=new ConcreteFactoryA();
            IProductA productA = factory.CreateProductA();
            IProductB productB = factory.CreateProductB();
            productA.DoSomething();
            productB.DoOtherthing();
            
            Console.WriteLine("Create FactoryB Instance");
            factory = new ConcreteFactoryB();
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
            productA.DoSomething();
            productB.DoOtherthing();

            Console.ReadKey();
        }
    }
}
