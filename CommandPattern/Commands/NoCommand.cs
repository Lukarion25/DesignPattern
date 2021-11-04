using System;

namespace CommandPattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Assigned");
        }

        public void Undo()
        {
            Execute();
        }
    }
}
