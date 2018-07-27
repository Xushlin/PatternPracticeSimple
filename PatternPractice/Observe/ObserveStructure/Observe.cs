using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Observe.ObserveStructure
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update();
    }

    public class ConcreteSubject:ISubject
    {
        IList<IObserver> _observers=new List<IObserver>();
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

    public class ConcreteObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("I'm Concrete Observer:)");
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class MyObservable : IObservable<User> {
        public IDisposable Subscribe(IObserver<User> observer)
        {
            observer.OnNext(new User {FirstName = "Michael", LastName = "Xu"});

            return null;
        }
    }

    public class MyObserver : IObserver<User>
    {
        public void OnNext(User value)
        {
            Console.WriteLine($"{value.FirstName} - {value.LastName}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Completed.");
        }
    }

    [Description("3.0 Observe parttern structure.")]
    public class App
    {
        static void Main()
        {
            ISubject subject=new ConcreteSubject();
            IObserver observer=new ConcreteObserver();
            subject.Register(observer);
            subject.Notify();

            IObservable<User> ob=new MyObservable();
            IObserver<User> Obs=new MyObserver();
            ob.Subscribe(Obs);

            

            Console.ReadKey();
        }
    }
}
