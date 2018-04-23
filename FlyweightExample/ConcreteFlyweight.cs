using System;

namespace FlyweightExample
{
    public class ConcreteFlyweight: IFlyweight
    {
        public void PrintFlyweight(string name)
        {
            Console.WriteLine(name);
        }
    }
}