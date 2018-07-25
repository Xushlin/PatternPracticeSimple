using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.AbstractFactory.Structure
{
    public interface IProductA
    {
        void DoSomething();
    }

    public interface IProductB
    {
        void DoOtherthing();
    }

    public interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public class ConcreteProductA1:IProductA
    {
        public void DoSomething()
        {
            Console.WriteLine("Hi I'm ProductA1");
        }
    }

    public class ConcreteProductA2 : IProductA
    {
        public void DoSomething()
        {
            Console.WriteLine("Hi I'm ProductA2");
        }
    }

    public class ConcreteProductB1:IProductB
    {
        public void DoOtherthing()
        {
            Console.WriteLine("Hi I'm ProductB1");
        }
    }

    public class ConcreteProductB2 : IProductB
    {
        public void DoOtherthing()
        {
            Console.WriteLine("Hi I'm ProductB2");
        }
    }

    public class ConcreteFactoryA:IFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    public class ConcreteFactoryB:IFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    [Description("3.0 Abstract factory structure.")]
    public class App
    {
        static void Main()
        {
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
