class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3);
        Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 4.8);
        Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 100, 15);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
