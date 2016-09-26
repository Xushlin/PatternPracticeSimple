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

            Console.ReadKey();
        }
    }
}
