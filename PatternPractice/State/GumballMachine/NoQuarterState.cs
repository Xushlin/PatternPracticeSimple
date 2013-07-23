using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.State.GumballMachine
{
    public  class NoQuarterState:IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void TumCrank()
        {
            Console.WriteLine("You turned,but there's no quarter.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }
    }
}
