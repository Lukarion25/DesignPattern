using System;

namespace StatePattern.States
{
    public class SoldState : IState
    {
        private GumballMachine Machine { get; }

        public SoldState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, already in progress");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Can't eject, already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice achieves nothing");
        }

        public void Dispense()
        {
            Machine.ReleaseBall();
            if (Machine.Count > 0)
            {
                Machine.State = Machine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops! No more gumballs");
                Machine.State = Machine.SoldOutState;
            }
        }
    }
}
