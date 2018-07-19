using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.StaticFactory.Structure
{
public interface IProduct
{
    void SomeMethod();
}

public class ConcreteProductA : IProduct
{
    public void SomeMethod()
    {
        Console.WriteLine("I am product A");
    }
}

public class ConcreteProductB : IProduct
{
    public void SomeMethod()
    {
        Console.WriteLine("I am product B");
    }
}
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

    [Description("1.1 Simple Factory Structure")]
    public class App
    {
static void Main()
{
    var product = Factory.Create("A");
    product.SomeMethod();

    product = Factory.Create("B");
    product.SomeMethod();

    Console.ReadKey();
}
    }
}
