using System;

namespace PatternPractice.Prototype
{
    public static class App
    {
        public static void Execute()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===========Prototype =========");
            Console.WriteLine("==============================");
            Prototype prototype;

            prototype = new ConcretePrototype1();

            prototype.Id = "Michael Xu";

            Console.WriteLine("New a ConcretePrototype1 Id="+prototype.Id);

            var cloneConcretePrototype1 = prototype.Clone();
            Console.WriteLine("Clone a ConcretePrototype1 Id="+cloneConcretePrototype1.Id);

            prototype = new ConcretePrototype2();

            prototype.Id = "Frank Li";

            Console.WriteLine("New a ConcretePrototype2 Id="+prototype.Id);

            var cloneConcretePrototype2 = prototype.Clone();
            Console.WriteLine("Clone a ConcretePrototype2 Id="+cloneConcretePrototype2.Id);
        }
    }
}