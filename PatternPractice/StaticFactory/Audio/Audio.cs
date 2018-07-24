using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.StaticFactory.Audio
{
public interface IAudio
{
    void Play(string name);
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
