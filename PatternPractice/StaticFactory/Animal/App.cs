using System;
using System.ComponentModel;

namespace PatternPractice.StaticFactory.Animal
{
    [Description("1.Static Factory ")]
    class App
    {
        static void Main()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===========Static Factory=====");
            Console.WriteLine("==============================");
            IAnimal animal = null;

            animal = AnimalFactory.CreateAnimal(AnimalType.Cat);
            animal.Say();

            animal = AnimalFactory.CreateAnimal(AnimalType.Dog);
            animal.Say();

            animal = AnimalFactory.CreateAnimal(AnimalType.Mouse);
            animal.Say();

            IProject project=new ProejctA();
            project.Create();
            project.Say();
        }
    }

    public interface IProject
    {
        void Say();
        IProject Create();
    }

    public class ProejctA:IProject
    {
        public void Say()
        {
            Console.WriteLine("Hello I'm ProjectA");
        }

        public IProject Create()
        {
            return new ProejctA();
        }
    }

    public class ProejctB:IProject
    {
        public void Say()
        {
            Console.WriteLine("Hello I'm ProjectB");
        }

        public IProject Create()
        {
            return new ProejctB();
        }
    }
}
