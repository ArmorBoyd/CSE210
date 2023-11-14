public class UserInterface
{
    public void Start()
    {
        Goal selectedGoal = null;

        while (true)
        {
            Console.WriteLine("Choose a goal to interact with:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    selectedGoal = new SimpleGoal("Run a Marathon", "Run 26.2 miles", 1000);
                    break;
                case "2":
                    selectedGoal = new ChecklistGoal("Attend Temple", "Visit the temple", 50, 10);
                    break;
                case "3":
                    selectedGoal = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
                    break;
                case "4":
                    Console.WriteLine("Quitting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            while (true)
            {
                selectedGoal.DisplayMenu();
                string actionChoice = Console.ReadLine();

                switch (actionChoice)
                {
                    case "1":
                        selectedGoal.RecordEvent();
                        break;
                    case "2":
                        Console.WriteLine($"Status: {selectedGoal.IsComplete()}");
                        break;
                    case "3":
                        Console.WriteLine("Returning to goal selection.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                if (actionChoice == "3")
                {
                    break;
                }
            }
        }
    }
}
