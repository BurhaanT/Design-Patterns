using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Console.WriteLine($"A house base price is: ${house.GetBuildPrice()}");

            DoubleStorey doubleStoreyHouse = new DoubleStorey(house);
            Console.WriteLine($"A double storey house price is: ${doubleStoreyHouse.GetBuildPrice()}");

            Console.ReadLine();
        }
    }
}
