namespace BuilderPattern.Builders
{
    public class HawaiianPizzaBuilder : IBuilder
    {
        private Pizza _pizza;

        public void AddIngredients()
        {
            _pizza.Ingredients = new string[] { "Flour", "Tomato Sauce", "Pineapple", "Mozarella", "Chicken" };
        }

        public void AddShape()
        {
            _pizza.Shape = "Circle";
        }

        public void AddSize()
        {
            _pizza.Size = "Large";
        }

        public Pizza Build()
        {
            return _pizza;
        }

        public void Reset()
        {
            _pizza = new Pizza();
        }
    }
}
