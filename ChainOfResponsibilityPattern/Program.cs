using ChainOfResponsibilityPattern.Operations;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create handlers
            var addition = new Addition();
            var subtraction = new Subtraction();
            var multiplication = new Multiplication();

            // Create chain
            subtraction.AddChain(multiplication);
            addition.AddChain(subtraction);

            // Execution
            double[] numbers = new double[] { 2, 3, 4, 5 };
            var additionResult = addition.Execute(numbers, "Add");
            var subtractionResult = addition.Execute(numbers, "Minus");
            var multResult = addition.Execute(numbers, "Multiply");
            var divisionResult = addition.Execute(numbers, "divide"); // Divide is not in the chain!!!

            Console.WriteLine("Addition = {0}", additionResult);
            Console.WriteLine("Subtraction = {0}", subtractionResult);
            Console.WriteLine("Multiplication = {0}", multResult);
            Console.WriteLine("Division = {0}", divisionResult);
        }
    }
}
