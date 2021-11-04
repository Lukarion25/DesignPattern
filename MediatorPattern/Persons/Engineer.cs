using System;

namespace MediatorPattern.Persons
{
    public class Engineer : Person
    {
        public Engineer(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to programmer: {message}");
        }
    }
}
