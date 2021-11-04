using System;

namespace TemplatePattern.Beverages
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Adding tea leaves to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon and Sugar");
            Sugar();
        }

        private new void Sugar()
        {
            Console.WriteLine($"adding {sugar} spoons of sugar");
        }

        public new int AddSugar
        {
            set { sugar = value; }
        }
    }
}
