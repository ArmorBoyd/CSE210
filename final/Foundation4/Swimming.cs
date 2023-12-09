public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (minutes / 60.0);
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }

    public override string GetSummary()
{
    double speed = Math.Round(GetSpeed(), 2); // Round speed to 2 decimal places
    double pace = Math.Round(GetPace(), 2); // Round pace to 2 decimal places

    return $"{date.ToShortDateString()} Swimming ({minutes} min): Laps {laps} | Distance {GetDistance()} kilometers | Speed: {speed.ToString("0.##")} kph | Pace: {pace.ToString("0.##")} mins per km";
}
}
