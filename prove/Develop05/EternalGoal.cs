using System;

public class EternalGoal : Goal
{
    public override void CreateGoal()
    {
        base.CreateGoal(); // Reuse base class's implementation for creating a goal
    }

    public override void ListGoal()
    {
        string status = IsComplete() ? "[]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) - Eternal Goal");
    }

    public override string SaveGoal() => $"{base.SaveGoal()}"; // Save the eternal goal details
    
}
