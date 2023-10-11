using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal
{
    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            DateTime date = DateTime.Now;
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            Console.Clear(); // Clear the console screen
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine(); 
        }

        public void SaveToFile()
        {
            try
            {
                Console.Write("Enter Filename: ");
                string filename = Console.ReadLine();
                filename = filename + ".txt";

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine("Date,Prompt,Response");

                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry.Date:MM/dd/yyyy},{entry.Prompt.Replace(",", ",,")},{entry.Response.Replace(",", ",,")}");
                    }
                }

                Console.WriteLine("Saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

       public void LoadFromFile()
{
    try
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        filename = filename + ".txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File does not exist.");
            return;
        }

        List<Entry> loadedEntries = new List<Entry>();

        using (StreamReader reader = new StreamReader(filename))
        {
            string headerLine = reader.ReadLine(); // Read and discard the header line

            while (!reader.EndOfStream)
            {
                string entryLine = reader.ReadLine();
                string[] fields = entryLine.Split(',');

                DateTime date = DateTime.ParseExact(fields[0], "MM/dd/yyyy", null);
                string prompt = fields[1].Replace(",,", ",");
                string response = fields[2].Replace(",,", ",");

                loadedEntries.Add(new Entry(prompt, response, date));
            }
        }

        // Replace existing entries with loaded entries
        entries.Clear();
        entries.AddRange(loadedEntries);

        Console.WriteLine("Loaded");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}
    }
}