using System;
using System.Collections.Generic;

namespace PatternPractice.Composite.RealWorld
{
    public class CompositeElement:DrawingElement
    {
        private readonly List<DrawingElement> _children=new List<DrawingElement>();
        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            _children.Add(drawingElement);
        }

        public override void Remove(DrawingElement drawingElement)
        {
            _children.Remove(drawingElement);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) +"+ " + Name);
            foreach (var drawingElement in _children)
            {
                drawingElement.Display(indent+2);
            }
        }
    }
}