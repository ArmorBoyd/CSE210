using System;

namespace DailyScripture
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Enter the scripture reference:");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter the scripture passage:");
            string passage = Console.ReadLine();

            Reference scriptureReference = new Reference(reference, 1, 1);
            Scripture scripture = new Scripture(scriptureReference, passage);

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}