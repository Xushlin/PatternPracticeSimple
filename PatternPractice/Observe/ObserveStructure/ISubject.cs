namespace PatternPractice.Observe.ObserveStructure
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }
}