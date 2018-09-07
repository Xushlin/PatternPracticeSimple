using System;

namespace PatternPractice.Flyweight.CharacterInstance
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            Symbol = 'A';
            Width = 100;
            Height = 120;
            Ascent = 70;
            Desccent = 0;
        }

        public override void Display(int pointSize)
        {
            this.PointSize = pointSize;
            Console.WriteLine(this.Symbol+" (pointsize "+pointSize+")");
        }
    }
}