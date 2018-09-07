namespace PatternPractice.Flyweight.CharacterInstance
{
    public abstract class Character
    {
        protected char Symbol { get; set; }
        protected int Width { get; set; }
        protected int Height { get; set; }
        protected int Ascent { get; set; }
        protected int Desccent { get; set; }
        protected int PointSize { get; set; }

        public abstract void Display(int pointSize);
    }
}