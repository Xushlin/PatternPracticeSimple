using System;

namespace PatternPractice.Mediator
{
    public abstract class Component
    {

        protected abstract IMediator Mediator { get; }

        public void Changed()
        {
            Mediator.ComponentChanged(this);
        }

        public abstract void Update();
    }

    public class ConcreteMediator : IMediator
    {
        public Button addButton;
        public List list;
        public TextBox userNameTextBox;
        public ComboBox cb;
        public void ComponentChanged(Component component)
        {
            if (component == addButton)
            {
                list.Update();
                cb.Update();
                userNameTextBox.Update();
            }
        }
    }
    public class Button:Component
    {
        public Button(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected override IMediator Mediator { get; }

        public override void Update()
        {
            Console.WriteLine("this is a button!");
        }
    }

    public class List:Component
    {
        public List(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected override IMediator Mediator { get; }

        public override void Update()
        {
            Console.WriteLine("Added an item to the list!");
        }

        public void Select()
        {
            Console.WriteLine("Selected an item from the list!");
        }
    }
    public class ComboBox : Component
    {
        public ComboBox(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected override IMediator Mediator { get; }

        public override void Update()
        {
            Console.WriteLine("Added an item to the ComboBox!");
        }

        public void Select()
        {
            Console.WriteLine("Selected an item from the ComboBox!");
        }
    }

    public class TextBox:Component
    {
        public TextBox(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected override IMediator Mediator { get; }

        public override void Update()
        {
            Console.WriteLine("Clear the text box content");
        }

        public void SetText()
        {
            Console.WriteLine("xiao long nv");
        }
    }
}