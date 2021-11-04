namespace BuilderPattern.Builders
{
    public class MargheritaPizzaBuilder : IBuilder
    {
        private Pizza _pizza;

        public void AddIngredients()
        {
            _pizza.Ingredients = new string[] { "Flour", "Tomato Sauce", "Boiled Ham", "Mozarella", "Olive" };
        }

        public void AddShape()
        {
            _pizza.Shape = "Circle";
        }

        public void AddSize()
        {
            _pizza.Size = "Small";
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
