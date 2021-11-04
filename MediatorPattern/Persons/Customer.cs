using System;

namespace MediatorPattern.Persons
{
    public class Customer : Person
    {
        public Customer(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to customer: {message}");
        }
    }
}
