using FactoryPattern.Factory_Method;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mauritius orders:");
            var mauritiusPizzaFactory = new MauritiusPizzaFactory();
            mauritiusPizzaFactory.Order("Cheese");
            Console.WriteLine();
            Console.WriteLine("France orders:");
            var francePizzaFactory = new FrancePizzaFactory();
            francePizzaFactory.Order("Clam");
        }
    }
}
