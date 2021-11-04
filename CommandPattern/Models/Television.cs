using System;

namespace CommandPattern.Models
{
    public class Television
    {
        private readonly string _name;

        public Television(string name)
        {
            _name = name;
        }

        internal void On()
        {
            Console.WriteLine($"{_name} Television On");
        }

        internal void Off()
        {
            Console.WriteLine($"{_name} Television Off");
        }
    }
}
