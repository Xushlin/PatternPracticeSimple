namespace PatternPractice.FactoryMethod.Audio
{
    public class Mp3Factory : IFactory
    {
        public IAudio Create()
        {
            return new Mp3();
        }
    }
}