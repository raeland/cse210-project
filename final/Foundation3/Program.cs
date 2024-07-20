using System;
namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("693 Driver St", "Springs", "CA", "99701");
            Address address2 = new Address("4126 Parker St", "Orlando", "FL", "34703");
            Address address3 = new Address("9556 Hood St", "Stuart", "PA", "03301");

            Event lecture = new Lecture("Perfection Talk", "Why Perfectionists die young", new DateTime(2024, 9, 16), "10:00 AM", address1, "Topher Gopher", 100);
            Event reception = new Reception("Talk A Lot Event", "Where everyone says too much but some say too little", new DateTime(2024, 12, 15), "6:00 PM", address2, "rsvp@yellowEvents.com");
            Event outdoorGathering = new OutdoorGathering("Bar-B-Q Picnic", "A fun picnic for the Perfectionists", new DateTime(2024, 7, 20), "2:00 PM", address3, "Sunny, no clouds in the sky");

            Event[] events = { lecture, reception, outdoorGathering };

            foreach (var evt in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(evt.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(evt.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(evt.GetShortDescription());
                Console.WriteLine();
                Console.WriteLine("---------------");
            }
        }
    }
}