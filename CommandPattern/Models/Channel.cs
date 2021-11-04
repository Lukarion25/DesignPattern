using System;

namespace CommandPattern.Models
{
    public class Channel
    {
        private readonly string _name;

        public Channel(string name)
        {
            _name = name;
        }

        internal void Next()
        {
            Console.WriteLine($"{_name} Next Channel");
        }

        internal void Previous()
        {
            Console.WriteLine($"{_name} Previous Channel");
        }
    }
}
