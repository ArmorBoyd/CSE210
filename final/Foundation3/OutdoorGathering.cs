using System;

namespace EventManagement
{
    class OutdoorGathering : Event
    {
        private string weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}Type of Event: Outdoor Gathering\nWeather Forecast: {weatherForecast}\n";
        }
    }
}
