namespace PatternPractice.Composite.RealWorld
{
    public abstract class DrawingElement
    {
        protected readonly string Name;

        protected DrawingElement(string name)
        {
            Name = name;
        }

        public abstract void Add(DrawingElement drawingElement);
        public abstract void Remove(DrawingElement drawingElement);
        public abstract void Display(int indent);
    }
}