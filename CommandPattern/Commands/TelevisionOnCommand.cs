using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class TelevisionOnCommand : ICommand
    {
        private readonly Television _television;

        public TelevisionOnCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.On();
        }

        public void Undo()
        {
            _television.Off();
        }
    }
}
