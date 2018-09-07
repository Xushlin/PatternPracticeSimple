using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.ChainOfResponsibility.Structure
{
    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }
        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handle Request#{request}");
            }else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request>=10 && request<20)
            {
                Console.WriteLine($"{this.GetType().Name} Handle Request# {request}");
            }else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 20 && request < 30)
            {
                Console.WriteLine($"{this.GetType().Name} Handle Request# {request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }

    public class RejectHandler:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 30)
            {
                Console.WriteLine($"{this.GetType().Name} Reject Handle Request# {request}");
            }
        }
    }
}
