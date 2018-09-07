using System;

namespace PatternPractice.FactoryMethod.Audio
{
    public class Mp3 : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing mp3...");
            Console.WriteLine($"The song name is: [{name}.mp3]");
            Console.WriteLine("..........");
        }
    }
}