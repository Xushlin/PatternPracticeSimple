using System;

namespace PatternPractice.FactoryMethod.Audio
{
    public class Acc : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing Acc...");
            Console.WriteLine($"The song name is: [{name}.acc]");
            Console.WriteLine("..........");
        }
    }
}