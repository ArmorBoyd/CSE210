using System;

public class SimpleGoal : Goal
{
    public override void CreateGoal()
    {
        base.CreateGoal(); // Reuse base class's implementation for creating a goal
    }

    public override void ListGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) - Simple Goal");
    }

    public override string SaveGoal() => $"{base.SaveGoal()}"; 
    public override int CalculateAGP()
    {
        if (IsComplete())
        {
            return 2; // 2 EXP for completing a SimpleGoal
        }
        return 0; // If goal not complete, return 0 EXP
}
}
