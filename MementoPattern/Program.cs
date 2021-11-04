using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryManager memoryManager = new MemoryManager();
            Sales sale = new Sales();

            ChangeSalesState(sale, "Noel van Halen", "(412) 256-0990", 25000.0);
            memoryManager.Insert(sale.SaveMemento());

            ChangeSalesState(sale, "Leo Welch", "(310) 209-7111", 1000000.0);
            memoryManager.Insert(sale.SaveMemento());

            ChangeSalesState(sale, "Moshe Binieli", "(972) 054-2477052", 3120000.0);
            memoryManager.Insert(sale.SaveMemento());

            sale.RestoreMemento(memoryManager.Get());
            sale.RestoreMemento(memoryManager.Get());
            sale.RestoreMemento(memoryManager.Get());
        }

        private static void ChangeSalesState(Sales sale, string newName, string newPhone, double newBudget)
        {
            sale.Name = newName;
            sale.Phone = newPhone;
            sale.Budget = newBudget;
        }
    }
}
