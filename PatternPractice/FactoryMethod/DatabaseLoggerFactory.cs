namespace PatternPractice.FactoryMethod
{
    public class DatabaseLoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DabaseLogger();
        }
    }
}