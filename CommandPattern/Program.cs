using CommandPattern.Commands;
using CommandPattern.Models;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tvRemoteControl = new TVRemoteControl(3);

            var fox = new Channel("Fox News");
            var foxChannelNext = new ChannelNextCommand(fox);
            var foxChannelPrevious = new ChannelPreviousCommand(fox);

            var abc = new Channel("ABC");
            var abcChannelNext = new ChannelNextCommand(abc);
            var abcChannelPrevious = new ChannelPreviousCommand(abc);

            var remoteButton = new OnOffStruct
            {
                On = foxChannelNext,
                Off = foxChannelPrevious
            };

            tvRemoteControl[0] = remoteButton;
            tvRemoteControl.PushOn(0);
            tvRemoteControl.PushUndo();
            tvRemoteControl.PushUndo();
            tvRemoteControl.PushOff(0);
            Console.WriteLine();

            var television = new Television("LG");

            ICommand[] televisionOn = { new TelevisionOnCommand(television), foxChannelNext, abcChannelNext };
            ICommand[] televisionOff = { abcChannelPrevious, foxChannelPrevious, new TelevisionOffCommand(television) };

            tvRemoteControl[2] = new OnOffStruct { On = new MacroCommand(televisionOn), Off = new MacroCommand(televisionOff) };

            try
            {
                tvRemoteControl.PushOn(2);
                Console.WriteLine();
                tvRemoteControl.PushOff(2);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops");
            }
        }
    }
}
