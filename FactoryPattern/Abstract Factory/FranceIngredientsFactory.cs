using FactoryPattern.Ingredients.Cheese;
using FactoryPattern.Ingredients.Clam;
using FactoryPattern.Ingredients.Dough;
using FactoryPattern.Ingredients.Sauce;
using FactoryPattern.Ingredients.Veggies;
using System.Collections.Generic;

namespace FactoryPattern.Abstract_Factory
{
    public class FranceIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Parmesan();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FreshClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new DeepDish();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new PlumTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            var oni = new Onion();
            var ccm = new Cucumber();
            var ppr = new Pepper();
            IVeggies[] arr = { oni, ccm, ppr };
            return arr;
        }
    }
}
