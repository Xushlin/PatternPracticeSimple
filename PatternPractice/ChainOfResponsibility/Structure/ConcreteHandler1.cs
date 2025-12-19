using System;

namespace PatternPractice.ChainOfResponsibility.Structure
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handle Request#{request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }
}