using System;
using VisitorPattern.Units;

namespace VisitorPattern.Visitors
{
    public class ApartmentVisitor : IUnitVisitor
    {
        public void VisitApartment(Apartment apartment)
        {
            Console.WriteLine("This is an apartment");
        }

        public void VisitStudio(Studio studio)
        {
        }

        public void VisitBedroom(Bedroom bedroom)
        {
        }

        public void VisitLivingRoom(LivingRoom livingRoom)
        {
        }
    }
}
