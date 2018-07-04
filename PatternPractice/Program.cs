using System;
using MiscUtil;

namespace PatternPractice
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationChooser.Run(typeof(Program), args);
//            State.GumballMachine.App.Excute();
//
//            StaticFactory.Animal.App.Execute();
//
//            FactoryMethod.App.Execute();
//
//            AbstractFactory.App.Execute();
//
//            Prototype.App.Execute();
//
//            Builder.App.Execute();
//
//            Adapter.App.Execute();
//
//            Mediator.App.Execute();

            Console.ReadKey();
        }
    }
}
