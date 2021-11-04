using System;

namespace FlyweightPattern.Beverages
{
    public class OolongMilkTea : IBeverage
    {

        public OolongMilkTea()
        {
            Console.WriteLine("Initializing an Oolong Milk Tea instance");
        }

        public void Drink()
        {
            Console.WriteLine("hmmm... this is oolong milk tea");
        }
    }
}
