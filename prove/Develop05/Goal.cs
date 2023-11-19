using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = Console.ReadLine();
        _goalPoints = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have completed the goal: {_name}");
        _status = true;
    }

    public virtual bool IsComplete() => _status;

    public abstract void ListGoal();

    public virtual int CalculateAGP() => IsComplete() ? _goalPoints : 0;

    public virtual string SaveGoal() => $"{GetType().Name}:{_name},{_description},{_goalPoints},{_status}";
}
