using System.Collections.Generic;

namespace PatternPractice.Flyweight.Structure
{
    public class FlyweightFactory
    {
        Dictionary<string, Flyweight> flyweights=new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("x",new ConcreteFlyweight());
            flyweights.Add("y",new ConcreteFlyweight());
            flyweights.Add("z",new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key];
        }
    }
}