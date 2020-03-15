using System;
using System.ComponentModel;

namespace PatternPractice.TemplateMethod.Sturcture
{
    public abstract class AbsctractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }

    public class ConcreteClassA : AbsctractClass
    {
        public override void PrimitiveOperation1() => Console.WriteLine(nameof(ConcreteClassA) + "." + nameof(PrimitiveOperation1));

        public override void PrimitiveOperation2() => Console.WriteLine(nameof(ConcreteClassA) + "." + nameof(PrimitiveOperation2));
    }

    public class ConcreteClassB : AbsctractClass
    {
        public override void PrimitiveOperation1() => Console.WriteLine($"{nameof(ConcreteClassB)}.{nameof(PrimitiveOperation1)}");

        public override void PrimitiveOperation2() => Console.WriteLine($"{nameof(ConcreteClassB)}.{nameof(PrimitiveOperation2)}");
    }

    [Description("TempalteMethod")]
    public class App{
        public static void Main(){
            AbsctractClass aA=new ConcreteClassA();
            aA.TemplateMethod();

            AbsctractClass aB=new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}