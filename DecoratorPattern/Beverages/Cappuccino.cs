namespace DecoratorPattern.Beverages
{
    public class Cappuccino : Beverage
    {
        public Cappuccino()
        {
            _description = "Cappuccino";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 2.99;
        }
    }
}
