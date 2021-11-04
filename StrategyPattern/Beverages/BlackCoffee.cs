using System;
using System.Threading;

namespace StrategyPattern.Beverages
{
    public class BlackCoffee : ICoffee
    {
        public void MakeCoffee()
        {
            Console.WriteLine("Making Black Coffee");
            Thread.Sleep(1000);
            Console.WriteLine("Done to make Black Coffee");
        }

        public string GetDetails()
        {
            return "Black Coffee with no sugar.";
        }
    }
}
