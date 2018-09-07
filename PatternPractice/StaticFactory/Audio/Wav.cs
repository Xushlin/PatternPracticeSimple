using System;

namespace PatternPractice.StaticFactory.Audio
{
    public class Wav : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing wav file...");
            Console.WriteLine($"The song name is: [{name}.wav]");
            Console.WriteLine("..........");
        }
    }
}