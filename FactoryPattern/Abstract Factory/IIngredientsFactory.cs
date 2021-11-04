using FactoryPattern.Ingredients.Cheese;
using FactoryPattern.Ingredients.Clam;
using FactoryPattern.Ingredients.Dough;
using FactoryPattern.Ingredients.Sauce;
using FactoryPattern.Ingredients.Veggies;
using System.Collections.Generic;

namespace FactoryPattern.Abstract_Factory
{
    public interface IIngredientsFactory
    {
        IDough CreateDough();

        IEnumerable<IVeggies> CreateVeggies();

        ISauce CreateSauce();

        ICheese CreateCheese();

        IClam CreateClam();
    }
}
