namespace CompositePattern
{
    public class FileItem : FileSystemItem
    {
        public FileItem(string name, long fileBytes) : base(name)
        {
            this.FileBytes = fileBytes;
        }

        public long FileBytes { get; }

        public override decimal GetSizeInKB()
        {
            return decimal.Divide(this.FileBytes, 1000);
        }
    }
}
