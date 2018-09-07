using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternPractice.ChainOfResponsibility.Structure;

namespace PatternPractice.ChainOfResponsibility
{
    [Description("1.1.1 Chain Of Responsibility Parttern")]
    public class App
    {
        static void Main()
        {
            Handler handler1=new ConcreteHandler1();
            Handler handler2=new ConcreteHandler2();
            Handler handler3=new ConcreteHandler3();
            Handler rejectHandler=new RejectHandler();
            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);
            handler3.SetSuccessor(rejectHandler);
            int[] requests = {2, 4, 6, 7, 8, 14, 34, 56, 23, 12, 45, 23, 27};
            foreach (var request in requests)
            {
                handler1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
