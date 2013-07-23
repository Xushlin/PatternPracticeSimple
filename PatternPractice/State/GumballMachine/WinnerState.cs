using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.State.GumballMachine
{
    public class WinnerState:IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait,we're already giving you a gumball.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry,you already turned the crank.");
        }

        public void TumCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER,you get tow gumballs for your Quarter.");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() > 0)
            {
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            }else
            {
                Console.WriteLine("Oops,out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }
    }
}
