using System;
using System.Threading;

namespace StrategyPattern.Beverages
{
    public class NessCoffee : ICoffee
    {
        public void MakeCoffee()
        {
            Console.WriteLine("Making Ness Coffee");
            Thread.Sleep(1000);
            Console.WriteLine("Done to make Ness Coffee");
        }

        public string GetDetails()
        {
            return "Ness Coffee with 2 sugar.";
        }
    }
}
