namespace PatternPractice.FactoryMethod
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}