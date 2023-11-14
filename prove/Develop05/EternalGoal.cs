public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsAmount)
        : base(name, description, pointsAmount) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {_name}. Gained {_pointsAmount} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }
}
