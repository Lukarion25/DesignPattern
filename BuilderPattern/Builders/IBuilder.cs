namespace BuilderPattern.Builders
{
    public interface IBuilder
    {
        void AddIngredients();
        void AddShape();
        void AddSize();
        void Reset();
        Pizza Build();
    }
}
