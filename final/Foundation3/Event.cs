using System;

namespace EventManagement
{
    class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string GetStandardDetails()
        {
            return $"Title: {title} | Description: {description} | Date: {date.ToShortDateString()} | Time: {time} | Address: {address}\n";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"Type of Event: {GetType().Name} | Title: {title} | Date: {date.ToShortDateString()}";
        }
    }
}
