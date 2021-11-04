using ChainOfResponsibilityPattern.Interfaces;

namespace ChainOfResponsibilityPattern.Bases
{
    public abstract class BaseChain : IChain
    {
        public void AddChain(IChain chain)
        {
            _nextChain = chain;
        }

        public abstract double? Execute(double[] values, string action);

        protected IChain _nextChain;
    }
}
