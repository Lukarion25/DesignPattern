using CommandPattern.Models;
using System;

namespace CommandPattern.Commands
{
    public class ChannelNextCommand : ICommand
    {
        private readonly Channel _channel;

        public ChannelNextCommand(Channel channel)
        {
            _channel = channel;
        }

        public void Execute()
        {
            _channel.Next();
        }

        public void Undo()
        {
            _channel.Previous();
        }
    }
}
