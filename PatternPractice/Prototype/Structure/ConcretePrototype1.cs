namespace PatternPractice.Prototype.Structure
{
    public class ConcretePrototype1 : Structure.Prototype
    {
        public override Structure.Prototype Clone()
        {
            return (Structure.Prototype) this.MemberwiseClone();
        }
    }
}