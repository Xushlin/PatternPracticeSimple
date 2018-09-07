using System;

namespace PatternPractice.StaticFactory.Audio
{
    public class AudioFactory
    {
        public static IAudio Create(string songType)
        {
            IAudio audio;
            switch (songType.ToUpper())
            {
                case "A":
                    audio = new Wav();
                    break;
                case "M":
                    audio = new Wma();
                    break;
                case "P":
                    audio = new Mp3();
                    break;
                default:
                    throw new ArgumentException("Invalid argument", nameof(songType));
            }

            return audio;
        }
    }
}