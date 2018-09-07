using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Composite.Structure
{
    public abstract class Component
    {
        protected Component(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Composite:Component
    {
        private List<Component> _children=new List<Component>();
        public Composite(string name):base(name)
        {
        }
        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+Name);
            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

    public class Left:Component
    {
        public Left(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }

    [Description("2.0.0 Composite structure.")]
    static class App
    {
        public static void Main()
        {
            Component root=new Composite("root");
            root.Add(new Left("Left A"));
            root.Add(new Left("Left B"));

            Component composite=new Composite("Composite X");
            composite.Add(new Left("Composite XA"));
            composite.Add(new Left("Composite XB"));

            root.Add(composite);
            root.Add(new Left("Leaf C"));

            Component leaf=new Left("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            
            root.Display(1);

            Console.ReadKey();
        }
    }
}
