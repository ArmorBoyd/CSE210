using System;

public class ChecklistGoal : Goal
{
    private int _completedTimes;
    private int _totalTimes;
    private int _bonusPoints;

    public override void CreateGoal()
    {
        base.CreateGoal(); // Reuse base class's implementation for creating a goal

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringTotalTimes = Console.ReadLine();
        _totalTimes = Convert.ToInt32(stringTotalTimes);

        Console.Write("Enter the bonus points when the goal is completed: ");
        string stringBonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(stringBonusPoints);
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have completed an item for the goal: {_name}");
        _completedTimes++;

        if (_completedTimes >= _totalTimes)
        {
            Console.WriteLine($"You've completed the checklist goal: {_name}. Bonus points awarded!");
            _status = true;
        }
    }

    public override bool IsComplete() => _status;

    public override void ListGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) - Completed {_completedTimes}/{_totalTimes} times - Checklist Goal");
    }

    public override int CalculateAGP()
    {
        int points = _completedTimes * _goalPoints;

        if (IsComplete())
        {
            points += _bonusPoints; // Use the bonus points set by the user
        }

        return points;
    }

    public override string SaveGoal() => $"{base.SaveGoal()},{_completedTimes},{_totalTimes}"; // Save the checklist goal details
}
