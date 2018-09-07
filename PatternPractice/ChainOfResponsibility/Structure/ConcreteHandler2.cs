using System;

namespace PatternPractice.ChainOfResponsibility.Structure
{
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
}