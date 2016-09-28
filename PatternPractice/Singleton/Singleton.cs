using System;

namespace PatternPractice.Singleton
{
    public class Singleton //线程不安全 bad
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }

    public sealed class EagerSingleton//线程安全
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();

        private EagerSingleton() { }

        public static EagerSingleton Instance => _instance;

        //public static EagerSingleton Instance { get; } = new EagerSingleton();
    }

    public class LazySingleton
    {
        private static LazySingleton _instance;
        private static readonly object padLock=new object();
        private LazySingleton() { }
        public static LazySingleton Instance
        {
            get
            {
                lock (padLock)
                {
                    if(_instance==null)
                        _instance=new LazySingleton();

                    return _instance;
                }
            }
        }
    }
    //Doble check Bad
    public class LazySingleton2
    {
        private static LazySingleton2 _instance;
        private static readonly object padLock=new object();
        private LazySingleton2() { }
        public static LazySingleton2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padLock)
                    {
                        if (_instance == null)
                            _instance = new LazySingleton2();

                    }
                }

                return _instance;
            }
        }
    }

    public sealed class Singleton2
    {
        Singleton2()
        {
        }

        public static Singleton2 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton2 instance = new Singleton2();
        }
    }


    public sealed class Singleton3
    {
        //private static readonly Lazy<Singleton3> lazy=new Lazy<Singleton3>(x=>new Singleton3()); 
        private static readonly Lazy<Singleton3> lazy =new Lazy<Singleton3>(() => new Singleton3());

        public static Singleton3 Instance { get { return lazy.Value; } }

        private Singleton3()
        {
        }
    }
}
