using System;

namespace PatternPractice.State.GumballMachine
{
    public class SoldOutState:IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter,the machine is sold out.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject,you haven't inserted a quarter yet.");
        }

        public void TumCrank()
        {
            Console.WriteLine("You turned,but there are no gumballs.");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumballs dispense.");
        }
    }
}
