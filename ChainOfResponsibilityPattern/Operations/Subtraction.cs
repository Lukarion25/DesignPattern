using ChainOfResponsibilityPattern.Bases;

namespace ChainOfResponsibilityPattern.Operations
{
    public class Subtraction : BaseChain
    {
        public override double? Execute(double[] values, string action)
        {
            if (action.ToLower() == "minus")
            {
                var result = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    result -= values[i];
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
