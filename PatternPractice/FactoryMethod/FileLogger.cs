using System;

namespace PatternPractice.FactoryMethod
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Write log to file.");
        }
    }
}