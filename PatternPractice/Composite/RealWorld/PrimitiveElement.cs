using System;

namespace PatternPractice.Composite.RealWorld
{
    public class PrimitiveElement:DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement drawingElement)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + Name);
        }
    }
}