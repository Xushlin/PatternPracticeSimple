using System;

namespace PatternPractice.StaticFactory.Audio
{
    public class Wma : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing wma file...");
            Console.WriteLine($"The song name is: [{name}.wma]");
            Console.WriteLine("..........");
        }
    }
}