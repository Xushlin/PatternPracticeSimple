using System;

namespace PatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            State.GumballMachine.App.Excute();

            StaticFactory.Animal.App.Execute();

            FactoryMethod.App.Execute();

            AbstractFactory.App.Execute();

            Prototype.App.Execute();

            Builder.App.Execute();

            Adapter.App.Execute();

            Console.ReadKey();
        }
    }
}
