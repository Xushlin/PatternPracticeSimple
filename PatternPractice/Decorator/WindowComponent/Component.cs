using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.Decorator.WindowComponent
{
    abstract class Component
    {
        public abstract void Display();
    }

    class Window : Component
    {
        public override void Display()
        {
            Console.WriteLine("This is a Window");
        }
    }

    class TextBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("This is a TextBox");
        }
    }

    class ListBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("This is a ListBox");
        }
    }

    abstract class ComponentDecorator : Component
    {
        private readonly Component component;

        public ComponentDecorator(Component component)
        {
            this.component = component;
        }
        public override void Display()
        {
            component.Display();
        }
    }

    class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(Component component) : base(component)
        {
        }

        public override void Display()
        {
            SAetScrollBar();
            base.Display();
        }

        public void SAetScrollBar()
        {
            Console.WriteLine("Add a ScrollBar.");
        }
    }

    class BlackBorderDecorator : ComponentDecorator
    {
        public BlackBorderDecorator(Component component) : base(component)
        {
        }
        public override void Display()
        {
            SetBlackBorder();
            base.Display();
        }

        public void SetBlackBorder()
        {
            Console.WriteLine("Add a BlackBorder");
        }
    }
    [Description("Window Decorator")]
    public class App
    {
        public static void Main()
        {
            Component window, scrollBarDecorator, blackBorderDecorator;
            window = new Window();
            scrollBarDecorator = new ScrollBarDecorator(window);
            blackBorderDecorator = new BlackBorderDecorator(scrollBarDecorator);
            blackBorderDecorator.Display();

            var textBox = new TextBox();
            scrollBarDecorator = new ScrollBarDecorator(textBox);
            blackBorderDecorator = new BlackBorderDecorator(scrollBarDecorator);
            blackBorderDecorator.Display();

            var listBox = new ListBox();
            scrollBarDecorator = new ScrollBarDecorator(listBox);
            blackBorderDecorator = new BlackBorderDecorator(scrollBarDecorator);
            blackBorderDecorator.Display();
        }
    }
}
