using BuilderPattern.Builders;

namespace BuilderPattern
{
    public class Chef
    {
        private IBuilder _builder;

        public Chef(IBuilder builder)
        {
            AcceptBuilder(builder);
        }

        private void AcceptBuilder(IBuilder builder)
        {
            _builder = builder;
            _builder.Reset();
        }

        public void ChangeBuilder(IBuilder builder)
        {
            AcceptBuilder(builder);
        }

        public Pizza Prepare()
        {
            _builder.AddIngredients();
            _builder.AddShape();
            _builder.AddSize();
            return _builder.Build();
        }
    }
}
