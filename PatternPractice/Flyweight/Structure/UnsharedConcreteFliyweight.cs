using System;

namespace PatternPractice.Flyweight.Structure
{
    public class UnsharedConcreteFliyweight:Flyweight
    {
        public override void Execute(int extrinsicstate)
        {
            Console.WriteLine(this.GetType().Name + ":" + extrinsicstate);
        }
    }
}