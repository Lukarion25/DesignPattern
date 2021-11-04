using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chef = new Chef(new HawaiianPizzaBuilder());
            var hawaiianPizzaBuilder = chef.Prepare();

            chef.ChangeBuilder(new MargheritaPizzaBuilder());
            var margheritaPizzaBuilder = chef.Prepare();

            Console.WriteLine($"Hawaiian Pizza: {hawaiianPizzaBuilder}");
            Console.WriteLine($"Margherita Pizza: {margheritaPizzaBuilder}");
        }
    }
}
