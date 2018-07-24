using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternPractice.StaticFactory.Structure;

namespace PatternPractice.FactoryMethod.Structure
{
public interface IProduct
{
    void DoSomething();
}
public interface IFactory
{
    IProduct Create();
}
public class ConcreteProductA : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("I'm Product A");
    }
}
public class ConcreteProductB : IProduct
{
    public void DoSomething()
    {
        Console.WriteLine("I'm Product B");
    }
}
public class ConcreteFactoryA : IFactory
{
    public IProduct Create()
    {
        return new ConcreteProductA();
    }
}
public class ConcreteFactoryB : IFactory
{
    public IProduct Create()
    {
        return new ConcreteProductB();
    }
}

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
