using AdapterPattern.Cats;
using AdapterPattern.Dogs;
using System;

namespace AdapterPattern.Adapters
{
    public class CatAdapter : IDog
    {
        private readonly ICat _cat;
        public CatAdapter(ICat cat)
        {
            _cat = cat;
        }

        public void Bark()
        {
            _cat.Meow();
        }

        public void Run()
        {
            for (int i = 0; i < 2; i++)
            {
                _cat.Run();
                Console.WriteLine("Resting...");
            }
        }
    }
}
