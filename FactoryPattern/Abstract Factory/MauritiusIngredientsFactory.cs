using FactoryPattern.Ingredients.Cheese;
using FactoryPattern.Ingredients.Clam;
using FactoryPattern.Ingredients.Dough;
using FactoryPattern.Ingredients.Sauce;
using FactoryPattern.Ingredients.Veggies;
using System.Collections.Generic;

namespace FactoryPattern.Abstract_Factory
{
    public class MauritiusIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese()
        {
            return new Mozarella();
        }

        IClam IIngredientsFactory.CreateClam()
        {
            return new FrozenClam();
        }

        IDough IIngredientsFactory.CreateDough()
        {
            return new ThinCrust();
        }

        ISauce IIngredientsFactory.CreateSauce()
        {
            return new CherryTomato();
        }

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies()
        {
            IVeggies[] arr = { new Onion(), new Pepper(), new Olive() };
            return arr;
        }
    }
}
