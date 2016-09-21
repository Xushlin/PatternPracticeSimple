using System;

namespace PatternPractice.State.GumballMachine
{
    public static class App
    {
        public static void Excute()
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
