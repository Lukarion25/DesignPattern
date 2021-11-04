using ChainOfResponsibilityPattern.Bases;

namespace ChainOfResponsibilityPattern.Operations
{
    public class Multiplication : BaseChain
    {
        public override double? Execute(double[] values, string action)
        {
            if (action.ToLower() == "multiply")
            {
                var result = 1.0;
                foreach (var value in values)
                {
                    result *= value;
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
