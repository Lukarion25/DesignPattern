using System;

namespace AdapterPattern.Cats
{
    public class Cat : ICat
    {
        public void Meow()
        {
            Console.WriteLine("Meow Meow");
        }

        public void Run()
        {
            Console.WriteLine("Run for 5 km.");
        }
    }
}
