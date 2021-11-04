using FactoryPattern.Abstract_Factory;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Factory_Method
{
    public class FrancePizzaFactory : PizzaFactory
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza;
            IIngredientsFactory ingredients = new FranceIngredientsFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients);
                pizza.Name = "Chicago Cheese";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients);
                pizza.Name = "Chicago Clam";
            }
            else
            {
                pizza = new VeggiePizza(ingredients);
                pizza.Name = "Chicago Veggie";
            }
            pizza.Color = "red";
            return pizza;
        }
    }
}
