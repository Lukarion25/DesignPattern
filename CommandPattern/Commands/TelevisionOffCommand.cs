using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class TelevisionOffCommand : ICommand
    {
        private readonly Television _television;

        public TelevisionOffCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.Off();
        }

        public void Undo()
        {
            _television.On();
        }
    }
}
