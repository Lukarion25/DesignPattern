using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}
