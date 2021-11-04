using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    public class MemoryManager
    {
        private List<Memento> _mementoList;

        public MemoryManager()
        {
            this._mementoList = new List<Memento>();
        }

        public void Insert(Memento memento)
        {
            this._mementoList.Add(memento);
        }

        public Memento Get()
        {
            if (this._mementoList.Count > 0)
            {
                Memento memento = this._mementoList.LastOrDefault();
                this._mementoList.RemoveAt(this._mementoList.Count - 1);
                return memento;
            }
            else
            {
                Console.WriteLine("Nothing in memory.");
                return null;
            }
        }
    }
}
