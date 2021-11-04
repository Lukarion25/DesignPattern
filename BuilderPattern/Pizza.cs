namespace BuilderPattern
{
    public class Pizza
    {
        public string Size { get; set; }
        public string Shape { get; set; }
        public string[] Ingredients { get; set; }
        public override string ToString()
        {
            var pizza = string.Empty;
            foreach (var ingredient in Ingredients)
            {
                pizza += $"{ingredient} ";
            }

            return $"Ingredients: {pizza}, Size: {Size}, Shape: {Shape}";
        }
    }
}
