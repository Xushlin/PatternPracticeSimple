﻿using System;
using System.ComponentModel;

namespace PatternPractice.Observe.Structure
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class MyObservable : IObservable<User> {
        private readonly User user;

        public MyObservable(User user)
        {
            this.user = user;
        }
        public IDisposable Subscribe(IObserver<User> observer)
        {
            observer.OnNext(user);

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

            var user = new User { FirstName = "Michael ", LastName = "Xu" };
            IObservable<User> ob=new MyObservable(user);
            
            IObserver<User> Obs=new MyObserver();
           
            ob.Subscribe(Obs);
            
            Console.ReadKey();
        }
    }
}
