using System;

namespace FlyweightPattern.Beverages
{
    public class CoconutMilkTea : IBeverage
    {
        public CoconutMilkTea()
        {
            Console.WriteLine("Initializing a Coconut Milk Tea instance");
        }

        public void Drink()
        {
            Console.WriteLine("hmmm... this is coconut milk tea");
        }
    }
}
