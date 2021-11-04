using System;

namespace AdapterPattern.Dogs
{
    public class Dog : IDog
    {
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }

        public void Run()
        {
            Console.WriteLine("Run for 10 km.");
        }
    }
}
