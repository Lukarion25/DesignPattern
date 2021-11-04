using DecoratorPattern.Beverages;
using DecoratorPattern.Toppings;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage firstBeverage = new Espresso();
            Console.WriteLine(firstBeverage.Description + " $" + firstBeverage.Cost());

            Beverage secondBeverage = new Cappuccino();
            secondBeverage = new MochaTopping(secondBeverage);
            secondBeverage = new MochaTopping(secondBeverage);
            secondBeverage = new WhipTopping(secondBeverage);
            Console.WriteLine(secondBeverage.Description + " $" + secondBeverage.Cost());

            Beverage thirdBeverage = new HouseBlend();
            thirdBeverage = new MochaTopping(thirdBeverage);
            thirdBeverage = new WhipTopping(thirdBeverage);
            Console.WriteLine(thirdBeverage.Description + " $" + thirdBeverage.Cost());
        }
    }
}
