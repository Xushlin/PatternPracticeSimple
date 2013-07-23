namespace PatternPractice.State.GumballMachine
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TumCrank();
        void Dispense();
    }
}
