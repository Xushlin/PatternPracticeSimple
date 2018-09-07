using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Flyweight.CharacterInstance
{
    [Description("4.2 Flyeight Character")]
    public class App
    {
        static void Main()
        {
            var text = "AABBZZAZBZZ";
            var factory=new CharacterFactory();
            var pointSize = 100;
            foreach (var c in text.ToCharArray())
            {
                var character = factory.GetCharactor(c);
                character.Display(pointSize--);
            }

            Console.ReadKey();
        }
    }
}
