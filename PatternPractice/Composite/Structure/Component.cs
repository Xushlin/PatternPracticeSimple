namespace PatternPractice.Composite.Structure
{
    public abstract class Component
    {
        protected Component(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
}