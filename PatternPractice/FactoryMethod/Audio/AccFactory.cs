namespace PatternPractice.FactoryMethod.Audio
{
    public class AccFactory : IFactory
    {
        public IAudio Create()
        {
            return new Acc();
        }
    }
}