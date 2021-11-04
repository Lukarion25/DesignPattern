using StrategyPattern.Beverages;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffee = new CoffeeMaker(new BlackCoffee());
            coffee.MakeCoffee();
            Console.WriteLine("Details about the coffee: " + coffee.GetDetails());

            coffee.MyCoffee = new NessCoffee();
            coffee.MakeCoffee();
            Console.WriteLine("Details about the coffee: " + coffee.GetDetails());
        }
    }
}
