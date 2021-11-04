namespace MediatorPattern.Persons
{
    public abstract class Person
    {
        protected Mediator mediator;

        public Person(Mediator mediator) => this.mediator = mediator;

        public virtual void Send(string message) => this.mediator.Send(message, this);

        public abstract void Notify(string message);
    }
}
