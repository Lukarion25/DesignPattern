using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new DirectoryItem("development");
            var project1 = new DirectoryItem("project1");
            var project2 = new DirectoryItem("project2");
            root.Add(project1);
            root.Add(project2);

            project1.Add(new FileItem("p1f1.txt", 2100));
            project1.Add(new FileItem("p1f2.txt", 3100));
            var subDirectory1 = new DirectoryItem("sub-directory1");
            subDirectory1.Add(new FileItem("p1f3.txt", 4100));
            subDirectory1.Add(new FileItem("p1f4.txt", 5100));
            project1.Add(subDirectory1);

            project2.Add(new FileItem("p2f1.txt", 6100));
            project2.Add(new FileItem("p2f2.txt", 7100));

            Console.WriteLine($"Total size (project2): {project2.GetSizeInKB()}");
            Console.WriteLine($"Total size (project1): {project1.GetSizeInKB()}");
            Console.WriteLine($"Total size (root) : {root.GetSizeInKB()}");
        }
    }
}
