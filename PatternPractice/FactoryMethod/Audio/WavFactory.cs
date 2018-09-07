namespace PatternPractice.FactoryMethod.Audio
{
    public class WavFactory : IFactory
    {
        public IAudio Create()
        {
            return new Wav();
        }
    }
}