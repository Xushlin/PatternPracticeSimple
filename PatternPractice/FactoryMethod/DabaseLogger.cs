using System;

namespace PatternPractice.FactoryMethod
{
    public class DabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Write log to database.");
        }
    }
}