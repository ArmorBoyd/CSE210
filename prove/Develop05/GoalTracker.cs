using System;
using System.Collections.Generic;
using System.IO;

public class GoalsTracker
{
    private List<Goal> _goals = new List<Goal>();
    private double _accumulatedPoints = 0; // Using double for decimal points in EXP
    private int _userLevel = 1;
    private const double EXPRequiredToLevelUp = 15; // EXP required to level up

    public double GetAccumulatedPoints() => _accumulatedPoints;

    public int GetUserLevel() => _userLevel;

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_accumulatedPoints); // Save accumulated points

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal()); // Save each goal's progress
            }
        }

        Console.WriteLine($"Goals saved to '{fileName}' successfully.");
    }

    public void LoadGoals(string fileName)
    {
        // Load goals from a file (implement this logic)
        Console.WriteLine($"Loading goals from '{fileName}'...");
        // Your code for loading goals from a file should go here
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
            LevelUp(); // Check for level up after recording an event
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void LevelUp()
    {
        // Logic for leveling up the user based on accumulated points
        if (_accumulatedPoints >= EXPRequiredToLevelUp)
        {
            _userLevel++;
            Console.WriteLine($"Congratulations! You've reached Level {_userLevel}!");
            _accumulatedPoints -= EXPRequiredToLevelUp; // Deduct the EXP required for leveling up
        }
    }
}
