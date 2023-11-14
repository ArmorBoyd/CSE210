public class ChecklistGoal : Goal
{
    private int _repetitionsRequired;
    private int _repetitionsCompleted;

    public ChecklistGoal(string name, string description, int pointsAmount, int repetitionsRequired)
        : base(name, description, pointsAmount)
    {
        _repetitionsRequired = repetitionsRequired;
        _repetitionsCompleted = 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {_name}. Gained {_pointsAmount} points.");
        CountRepetitions();
    }

    public override bool IsComplete()
    {
        return _repetitionsCompleted >= _repetitionsRequired;
    }

    private void CountRepetitions()
    {
        _repetitionsCompleted++;
        if (_repetitionsCompleted == _repetitionsRequired)
        {
            Console.WriteLine($"Congratulations! {_name} completed {_repetitionsCompleted}/{_repetitionsRequired} times.");
        }
    }
}
