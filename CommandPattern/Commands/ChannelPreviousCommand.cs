using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class ChannelPreviousCommand : ICommand
    {
        private readonly Channel _channel;

        public ChannelPreviousCommand(Channel channel)
        {
            _channel = channel;
        }

        public void Execute()
        {
            _channel.Previous();
        }

        public void Undo()
        {
            _channel.Next();
        }
    }
}
