using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("testImage.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine("\n");

            //image will not be loaded from disk
            image.Display();
        }
    }
}
