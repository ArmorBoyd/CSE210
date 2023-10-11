using System;

namespace DailyJournal
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public Entry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"Date: {Date:MM/dd/yyyy} - Prompt: {Prompt}\n{Response}\n";
        }
    }
}