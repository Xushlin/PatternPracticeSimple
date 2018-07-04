using System;
using System.ComponentModel;

namespace PatternPractice.State.GumballMachine
{
    [Description("9.State")]
    public static class App
    {
        public static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===========State=====");
            Console.WriteLine("==============================");
            var gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);
            //Todo:Test git opration.
        }
    }
}
