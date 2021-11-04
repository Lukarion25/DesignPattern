namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IChain
    {
        void AddChain(IChain chain);

        double? Execute(double[] values, string action);
    }
}
