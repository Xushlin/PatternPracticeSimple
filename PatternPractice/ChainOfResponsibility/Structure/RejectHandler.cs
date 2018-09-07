using System;

namespace PatternPractice.ChainOfResponsibility.Structure
{
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
