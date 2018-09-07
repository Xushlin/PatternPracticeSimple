namespace PatternPractice.FactoryMethod.Log
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}