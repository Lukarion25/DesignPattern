using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    public class DirectoryItem : FileSystemItem
    {
        private List<FileSystemItem> items { get; } = new List<FileSystemItem>();

        public DirectoryItem(string name) : base(name)
        {
        }

        public IReadOnlyList<FileSystemItem> Items => items;

        public void Add(FileSystemItem component)
        {
            this.items.Add(component);
        }

        public void Remove(FileSystemItem component)
        {
            this.items.Remove(component);
        }

        public override decimal GetSizeInKB()
        {
            return this.Items.Sum(x => x.GetSizeInKB());
        }
    }
}
