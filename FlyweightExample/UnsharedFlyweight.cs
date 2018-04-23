using System;

namespace FlyweightExample
{
    public class UnsharedFlyweight: IFlyweight
    {
        private object _state;

        public void PrintFlyweight(string unsharedName)
        {
            _state = unsharedName;
            Console.WriteLine(unsharedName);
        }
    }
}