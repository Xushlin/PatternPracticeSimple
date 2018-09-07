using System;
using System.ComponentModel;

namespace PatternPractice.FactoryMethod.Audio
{
    [Description("2.1. Factory Mothed payer")]
    public class App
    {
        static void Main()
        {
            //Wma play
            IFactory wmaFactory = new WmaFactory();
            IAudio wamAudio = wmaFactory.Create();
            wamAudio.Play("take me to your hert");
            //Wav play
            IFactory wavFactory = new WavFactory();
            IAudio wavAudio = wavFactory.Create();
            wavAudio.Play("take me to your hert");
            //Mp3 play
            IFactory mp3Factory = new Mp3Factory();
            IAudio mp3Audio = mp3Factory.Create();
            mp3Audio.Play("take me to your hert");
            //Acc play
            IFactory accFactory = new AccFactory();
            IAudio accAudio = accFactory.Create();
            accAudio.Play("take me to your hert");

            Console.ReadKey();
        }
    }
}
