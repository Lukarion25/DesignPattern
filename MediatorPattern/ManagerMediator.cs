using MediatorPattern.Persons;

namespace MediatorPattern
{
    public class ManagerMediator : Mediator
    {
        public Person Customer { get; set; }
        public Person Engineer { get; set; }
        public Person Tester { get; set; }

        public override void Send(string message, Person person)
        {
            if (person == Customer)
            {
                Engineer.Notify(message);
            }
            else if (person == Engineer)
            {
                Tester.Notify(message);
            }
            else Customer.Notify(message);
        }
    }
}
