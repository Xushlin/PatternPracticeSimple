namespace PatternPractice.FactoryMethod.Audio
{
    public class WmaFactory : IFactory
    {
        public IAudio Create()
        {
            return new Wma();
        }
    }
}