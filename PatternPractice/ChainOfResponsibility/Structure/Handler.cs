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
}