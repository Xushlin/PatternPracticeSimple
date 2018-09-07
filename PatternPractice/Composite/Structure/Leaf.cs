using System;

namespace PatternPractice.Composite.Structure
{
    public class Leaf:Component
    {
        public Leaf(string name) : base(name)
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
}