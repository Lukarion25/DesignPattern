using AdapterPattern.Adapters;
using AdapterPattern.Cats;
using AdapterPattern.Dogs;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();
            var catAdapter = new CatAdapter(cat);

            cat.Meow();
            cat.Run();
            Console.WriteLine();

            dog.Bark();
            dog.Run();
            Console.WriteLine();

            catAdapter.Bark();
            catAdapter.Run();
            Console.WriteLine();
        }
    }
}
