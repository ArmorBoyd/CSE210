using System;
using System.Collections.Generic;
using System.IO;
public class GoalsTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints() => _accumulatedPoints;

    public void SaveGoals()
    {
        Console.WriteLine("Saving goals to a file...");
        // Code for saving goals to a file
    }

    public void LoadGoals()
    {
        Console.WriteLine("Loading goals from a file...");
        // Code for loading goals from a file
    }

    public void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            goal.ListGoal();
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _accumulatedPoints += _goals[goalIndex].CalculateAGP();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}