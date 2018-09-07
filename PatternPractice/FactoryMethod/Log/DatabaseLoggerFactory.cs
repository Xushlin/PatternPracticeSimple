namespace PatternPractice.FactoryMethod.Log
{
    public class DatabaseLoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DabaseLogger();
        }
    }
}