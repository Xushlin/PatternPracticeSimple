using System.Collections.Generic;

namespace PatternPractice.Observe.Structure
{
    public class ConcreteSubject:ISubject
    {
        readonly IList<IObserver> _observers=new List<IObserver>();
        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}