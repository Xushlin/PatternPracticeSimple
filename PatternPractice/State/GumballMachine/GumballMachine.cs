using System;

namespace PatternPractice.State.GumballMachine
{
    public class GumballMachine
    {
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _soldOutState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState=new WinnerState(this);

            _count = numberGumballs;
            _state = numberGumballs > 0 ? _noQuarterState : _soldOutState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TumCrank();
            _soldState.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes relling out the slot...");
            if (_count != 0)
            {
                _count = _count - 1;
            }
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
