using System;
using System.Collections;
using System.Collections.Generic;

namespace FlyweightExample
{
    public class FlyweightFactory
    {
        readonly Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public int TotalObjectsCreated => flyweights.Count;

        public IFlyweight GetFlyweight(string flyweightType)
        {
            IFlyweight flyweight;
            if (flyweights.ContainsKey(flyweightType))
            {
                flyweight = flyweights[flyweightType];
            }
            else
            {
                switch (flyweightType)
                {
                    case "Concrete":
                        flyweight = new ConcreteFlyweight();
                        flyweights.Add("Concrete", flyweight);
                        break;
                    case "Unshared":
                        flyweight = new UnsharedFlyweight();
                        flyweights.Add("Unshared", flyweight);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return flyweight;
        }
    }
}