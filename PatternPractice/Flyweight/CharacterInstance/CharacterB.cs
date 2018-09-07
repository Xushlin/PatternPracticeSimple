using System;

namespace PatternPractice.Flyweight.CharacterInstance
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            Symbol = 'B';
            Width = 100;
            Height = 140;
            Ascent = 76;
            Desccent = 0;
        }

        public override void Display(int pointSize)
        {
            this.PointSize = pointSize;
            Console.WriteLine(this.Symbol + " (pointsize " + pointSize + ")");
        }
    }
}