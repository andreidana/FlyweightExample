using System;

namespace FlyweightExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            IFlyweight flyweight = flyweightFactory.GetFlyweight("Concrete");
            flyweight.PrintFlyweight("Concrete");
            flyweight = flyweightFactory.GetFlyweight("Concrete");
            flyweight.PrintFlyweight("Concrete");
            flyweight = flyweightFactory.GetFlyweight("Concrete");
            flyweight.PrintFlyweight("Concrete");

            flyweight = flyweightFactory.GetFlyweight("Unshared");
            flyweight.PrintFlyweight("Unshared");
            flyweight = flyweightFactory.GetFlyweight("Unshared");
            flyweight.PrintFlyweight("Unshared");
            flyweight = flyweightFactory.GetFlyweight("Unshared");
            flyweight.PrintFlyweight("Unshared");

            int NumObjs = flyweightFactory.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);
        }
    }
}
