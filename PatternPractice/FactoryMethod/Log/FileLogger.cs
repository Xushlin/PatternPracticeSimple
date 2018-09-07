using System;

namespace PatternPractice.FactoryMethod.Log
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Write log to file.");
        }
    }
}