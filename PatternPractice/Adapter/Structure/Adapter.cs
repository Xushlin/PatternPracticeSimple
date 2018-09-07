namespace PatternPractice.Adapter.Structure
{
    public class Adapter:ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Request()
        {
            _adaptee.PerformRequest();
        }
    }
}