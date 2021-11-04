using System;

namespace MediatorPattern.Persons
{
    public class Tester : Person
    {
        public Tester(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to tester: {message}");
        }
    }
}
