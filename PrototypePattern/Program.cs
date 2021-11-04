using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CloneFactory cloneFactory = new CloneFactory();
            Mouse mouse = new Mouse();

            Mouse clonedSheep = (Mouse)cloneFactory.GetClone(mouse);

            Console.WriteLine(mouse.Name);
            Console.WriteLine(clonedSheep.Name);
        }
    }
}
