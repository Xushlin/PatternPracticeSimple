using System;
using System.ComponentModel;

namespace PatternPractice.FactoryMethod.Structure
{
    [Description("2.0 Method Factory Structure")]
    public class App
    {
        static void Main()
        {
            //使用ConcreteFactoryA 创建产品 ProductA
            IFactory factoryA = new ConcreteFactoryA();
            IProduct productA = factoryA.Create();
            productA.DoSomething();

            //使用ConcreteFactoryB 创建产品 ProductB
            IFactory factoryB = new ConcreteFactoryB();
            IProduct productB = factoryB.Create();
            productB.DoSomething();

            Console.ReadKey();
        }
    }
}
