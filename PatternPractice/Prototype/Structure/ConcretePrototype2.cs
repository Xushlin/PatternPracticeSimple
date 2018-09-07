namespace PatternPractice.Prototype.Structure
{
    public class ConcretePrototype2 : Structure.Prototype
    {
        public override Structure.Prototype Clone()
        {
            return (Structure.Prototype) this.MemberwiseClone();
        }
    }
}