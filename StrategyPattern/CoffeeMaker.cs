using StrategyPattern.Beverages;

namespace StrategyPattern
{
    public class CoffeeMaker
    {
        public ICoffee MyCoffee { get; set; }

        public CoffeeMaker(ICoffee coffee)
        {
            this.MyCoffee = coffee;
        }

        public void MakeCoffee()
        {
            this.MyCoffee.MakeCoffee();
        }

        public string GetDetails()
        {
            return this.MyCoffee.GetDetails();
        }
    }
}
