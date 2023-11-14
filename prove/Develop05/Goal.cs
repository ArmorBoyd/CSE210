using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointsAmount;

    public Goal(string name, string description, int pointsAmount)
    {
        _name = name;
        _description = description;
        _pointsAmount = pointsAmount;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public void DisplayMenu()
    {
        Console.WriteLine($"1. Record Event for {_name}");
        Console.WriteLine($"2. Check {_name} Status");
        Console.WriteLine("3. Quit");
    }

    public void LoadFile()
    {
        Console.WriteLine("Loading goals from file...");
    }

    public void SaveFile()
    {
        Console.WriteLine("Saving goals to file...");
    }
}
