using System;

namespace PatternPractice.ChainOfResponsibility.Structure
{
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
}