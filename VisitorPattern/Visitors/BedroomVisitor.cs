using System;
using VisitorPattern.Units;

namespace VisitorPattern.Visitors
{
    public class BedroomVisitor : IUnitVisitor
    {
        public void VisitApartment(Apartment apartment)
        {
        }

        public void VisitStudio(Studio studio)
        {
        }

        public void VisitBedroom(Bedroom bedroom)
        {
            Console.WriteLine("Here is a bedroom");
        }

        public void VisitLivingRoom(LivingRoom livingRoom)
        {
        }
    }
}
