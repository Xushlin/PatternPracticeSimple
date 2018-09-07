using System;
using System.ComponentModel;
using PatternPractice.Adapter.ScoreOperation;

namespace PatternPractice.Adapter.Structure
{
    [Description("7.Adapter structure")]
    public static class App
    {
        public static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("========Adapter structure=====");
            Console.WriteLine("==============================");
           
            ITarget target=new Adapter(new Adaptee());
            target.Request();

        }
    }
}
