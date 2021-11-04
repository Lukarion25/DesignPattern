using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
    public abstract class ToppingDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
