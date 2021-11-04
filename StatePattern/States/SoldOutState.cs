using System;

namespace StatePattern.States
{
    public class SoldOutState : IState
    {
        public GumballMachine Machine { get; }

        public SoldOutState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry! Sold Out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Can't eject when sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("turning crank achieves nothing");
        }

        public void Dispense()
        {
            Console.WriteLine("Can't dispense when out of stock");
        }
    }
}
