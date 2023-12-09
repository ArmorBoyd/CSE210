using System;

namespace EventManagement
{
    class Lecture : Event
    {
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            this.speaker = speaker;
            this.capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}Type of Event: Lecture | Speaker: {speaker} | Capacity: {capacity} \n";
        }
    }
}
