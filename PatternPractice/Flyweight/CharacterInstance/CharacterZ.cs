using System;

namespace PatternPractice.Flyweight.CharacterInstance
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            Symbol = 'Z';
            Width = 100;
            Height = 120;
            Ascent = 66;
            Desccent = 0;
        }

        public override void Display(int pointSize)
        {
            this.PointSize = pointSize;
            Console.WriteLine(this.Symbol + " (pointsize " + pointSize + ")");
        }
    }
}