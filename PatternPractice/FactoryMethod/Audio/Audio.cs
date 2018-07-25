using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PatternPractice.StaticFactory.Audio;

namespace PatternPractice.FactoryMethod.Audio
{
    public interface IAudio
    {
        void Play(string name);
    }
    public interface IFactory
    {
        IAudio Create();
    }

    public class MyObserve : IObserver<IAudio>
    {
        public void OnNext(IAudio value)
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }

    public class MyObservable:IObservable<IAudio>
    {
        public IDisposable Subscribe(IObserver<IAudio> observer)
        {
            observer.OnNext(new Mp3());
            return null;
        }
    }

    public class Wma : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing wma file...");
            Console.WriteLine($"The song name is: [{name}.wma]");
            Console.WriteLine("..........");
            
        }
    }
    public class Wav : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing wav file...");
            Console.WriteLine($"The song name is: [{name}.wav]");
            Console.WriteLine("..........");
        }
    }
    public class Mp3 : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing mp3...");
            Console.WriteLine($"The song name is: [{name}.mp3]");
            Console.WriteLine("..........");
        }
    }

    public class Acc : IAudio
    {
        public void Play(string name)
        {
            Console.WriteLine("Start playing Acc...");
            Console.WriteLine($"The song name is: [{name}.acc]");
            Console.WriteLine("..........");
        }
    }

    public class WmaFactory : IFactory
    {
        public IAudio Create()
        {
            return new Wma();
        }
    }

    public class WavFactory : IFactory
    {
        public IAudio Create()
        {
            return new Wav();
        }
    }

    public class Mp3Factory : IFactory
    {
        public IAudio Create()
        {
            return new Mp3();
        }
    }

    public class AccFactory : IFactory
    {
        public IAudio Create()
        {
            return new Acc();
        }
    }

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
