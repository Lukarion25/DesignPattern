using FactoryPattern.Abstract_Factory;
using FactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory_Method
{
    public class MauritiusPizzaFactory : PizzaFactory
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza;
            IIngredientsFactory ingredients = new MauritiusIngredientsFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredients) { Name = "NY Style Cheese" };
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredients) { Name = "NY Style Clam" };
            }
            else
            {
                pizza = new VeggiePizza(ingredients) { Name = "NY Style Veggie" };
            }
            pizza.Color = "blue";
            return pizza;
        }
    }
}
