using System;

namespace FlyweightPattern.Beverages
{
    public class BubbleMilkTea : IBeverage
    {
        public BubbleMilkTea()
        {
            Console.WriteLine("Initializing a Bubble Milk Tea instance");
        }

        public void Drink()
        {
            Console.WriteLine("hmmm... this is bubble milk tea");
        }
    }
}
