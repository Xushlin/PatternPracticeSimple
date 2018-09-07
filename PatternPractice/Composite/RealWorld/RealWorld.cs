using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

    public class CompositeElement:DrawingElement
    {
        private List<DrawingElement> _children=new List<DrawingElement>();
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
            Console.WriteLine(new String('-', indent) +"+ " + Name);
            foreach (var drawingElement in _children)
            {
                drawingElement.Display(indent+2);
            }
        }
    }
    [Description("2.0.1 Composite instance")]
    public class App
    {
        public static void Main()
        {
            DrawingElement root =new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            DrawingElement comp =new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement

            DrawingElement pe =new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
