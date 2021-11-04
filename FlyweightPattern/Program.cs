namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var teaShop = new BubbleTeaShop();
            teaShop.Enumerate();
        }
    }
}
