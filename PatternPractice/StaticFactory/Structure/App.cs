using System;
using System.ComponentModel;

namespace PatternPractice.StaticFactory.Structure
{
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
