using System;

namespace EventManagement
{
    class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}Type of Event: Reception | RSVP Email: {rsvpEmail}\n";
        }

    }
}
