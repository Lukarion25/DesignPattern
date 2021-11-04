using ChainOfResponsibilityPattern.Bases;

namespace ChainOfResponsibilityPattern.Operations
{
    public class Addition : BaseChain
    {
        public override double? Execute(double[] values, string action)
        {
            if (action.ToLower() == "add")
            {
                double result = 0.0;
                foreach (var value in values)
                {
                    result += value;
                }
                return result;
            }
            else
            {
                return _nextChain?.Execute(values, action);
            }
        }
    }
}
