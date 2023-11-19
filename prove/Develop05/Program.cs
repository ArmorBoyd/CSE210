using System;

class Program
{
    static void Main(string[] args)
    {
        GoalsTracker goalsTracker = new GoalsTracker();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Accumulated Points");
            Console.WriteLine("5. Save File");
            Console.WriteLine("6. Load File");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Creating a new goal...");
                    Console.WriteLine("Select the type of goal:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter your choice: ");

                    string goalTypeChoice = Console.ReadLine();

                    switch (goalTypeChoice)
                    {
                        case "1":
                            Goal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateGoal();
                            goalsTracker.AddGoal(newSimpleGoal);
                            break;

                        case "2":
                            Goal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateGoal();
                            goalsTracker.AddGoal(newEternalGoal);
                            break;

                        case "3":
                            Goal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateGoal();
                            goalsTracker.AddGoal(newChecklistGoal);
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;

                case "2":
                Console.Clear();
                    Console.WriteLine("Listing goals...");
                    goalsTracker.ListGoals();
                    break;

                case "3":
                Console.Clear();
                    Console.WriteLine("Recording event...");
                    Console.Write("Enter the index of the goal to record event for: ");
                    int goalIndex = Convert.ToInt32(Console.ReadLine());
                    goalsTracker.RecordEvent(goalIndex);
                    break;

                case "4":
                Console.Clear();
                    Console.WriteLine($"Accumulated Points: {goalsTracker.GetAccumulatedPoints()}");
                    break;

                case "5":
                    Console.WriteLine("Enter the file name to save the goals:");
                    
                    
                    break;

                case "6":
                    Console.WriteLine("Enter the file name to load the goals:");
                
                    break;

                case "7":
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
