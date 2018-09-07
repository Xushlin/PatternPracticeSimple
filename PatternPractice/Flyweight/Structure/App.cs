using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Flyweight.Structure
{
    [Description("4.1 Flyweight structure")]
    public class App
    {
        static void Main()
        {
            int extrinsicstate = 100;
            var factory=new FlyweightFactory();
            Flyweight flyweight = factory.GetFlyweight("x");

            flyweight.Execute(--extrinsicstate);

            flyweight = factory.GetFlyweight("y");
            flyweight.Execute(--extrinsicstate);

            flyweight = factory.GetFlyweight("z");
            flyweight.Execute(--extrinsicstate);

            flyweight=new UnsharedConcreteFliyweight();
            flyweight.Execute(--extrinsicstate);

            Console.ReadKey();
        }
    }
}
