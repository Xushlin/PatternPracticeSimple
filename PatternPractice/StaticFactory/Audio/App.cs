using System;
using System.ComponentModel;

namespace PatternPractice.StaticFactory.Audio
{
    [Description("1.2. Simple Factory")]
    public class App
    {
        static void Main()
        {
            Console.WriteLine("Please input a or m or p");
            var input = Console.ReadKey();
            if (input != null)
            {
                IAudio audio = AudioFactory.Create(input.Key.ToString());
                audio.Play("take me to your hert");
            }

            Console.ReadKey();
        }
    }
}
