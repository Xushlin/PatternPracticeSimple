namespace PatternPractice.Prototype.Structure
{
    public abstract class Prototype
    {
        public string Id { get; set; }

        public abstract Prototype Clone();
    }
}
