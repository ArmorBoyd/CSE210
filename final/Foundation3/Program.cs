using System;

namespace EventManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("Chestnut Street", "City of Burgos", "University State", "6969");
            Address address2 = new Address("Roxas Street", "City of Cabaruan", "Isabela State ", "9696");
            Address address3 = new Address("Burgos Street", "San Fermin City", "Purok State ", "6699");

            Lecture lectureEvent = new Lecture("Learn Coding", "Introduction to Programming", new DateTime(2023, 12, 15), new TimeSpan(10, 0, 0), address1, "Boydie Pobs", 15);
            Reception receptionEvent = new Reception("Wedding Night", "For time and Eternity", new DateTime(2023, 11, 20), new TimeSpan(18, 30, 0), address2, "Can you please RSVP a response? I would greatly appreciate if you could let me know if you will be attending");
            OutdoorGathering outdoorEvent = new OutdoorGathering("River Side Picnic", "Enjoy the Outdoors", new DateTime(2023, 7, 8), new TimeSpan(12, 0, 0), address3, "Sunny");

            Console.WriteLine("Lecture Event Details");
            Console.WriteLine("Standard Details:");
            Console.WriteLine(lectureEvent.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(lectureEvent.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(lectureEvent.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Reception Event Details");
            Console.WriteLine("Standard Details:");
            Console.WriteLine(receptionEvent.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(receptionEvent.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(receptionEvent.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("Outdoor Gathering Event Details");
            Console.WriteLine("Standard Details:");
            Console.WriteLine(outdoorEvent.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(outdoorEvent.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(outdoorEvent.GetShortDescription());
        }
    }
}
