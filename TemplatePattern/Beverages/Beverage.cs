using System;

namespace TemplatePattern.Beverages
{
    public abstract class Beverage
    {
        protected int sugar;

        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            if (WantsCondiments)
                AddCondiments();
        }

        public bool WantsCondiments { private get; set; }

        protected abstract void Brew();

        private void Boil()
        {
            Console.WriteLine("Boling Water");
        }

        private void Pour()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void AddCondiments();

        public int AddSugar { get; set; }

        protected void Sugar() { }
    }
}
