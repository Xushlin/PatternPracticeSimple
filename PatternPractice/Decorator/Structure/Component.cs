using System;
using System.ComponentModel;

namespace PatternPractice.Decorator.Structure
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Component");
        }
    }

    public abstract class Decorator : Component
    {
        private Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = " New State";
            Console.WriteLine(nameof(ConcreteDecoratorA)+addedState);
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();            
        }

        private void AddedBehavior()
        {
            Console.WriteLine(nameof(ConcreteDecoratorB)+" Added new behavior");
        }
    }
    [Description("Decorator")]
    public class App
    {
        public static void Main()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(c);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();
        }
    }
}
