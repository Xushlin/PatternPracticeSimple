using System;

namespace PatternPractice.Mediator
{
    public static class App
    {
        public static void Execute()
        {

            Console.WriteLine("==============================");
            Console.WriteLine("===========Mediator =====");
            Console.WriteLine("==============================");

            ConcreteMediator mediator =new ConcreteMediator();
            Button btn=new Button(mediator);
            ComboBox cb=new ComboBox(mediator);
            List lst=new List(mediator);
            TextBox tb=new TextBox(mediator);

            mediator.list = lst;
            mediator.addButton = btn;
            mediator.cb = cb;
            mediator.userNameTextBox = tb;

            btn.Changed();

            cb.Select();
            cb.Changed();
        }
    }
}