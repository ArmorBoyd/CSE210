public class Cycling : Activity
{
    private double distance;

    public Cycling(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance; 
    }

    public override double GetSpeed()
    {
        return (distance / minutes) * 60; // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return minutes / distance; // Pace in minutes per kilometer
    }

    public override string GetSummary()
{
    double speed = Math.Round(GetSpeed(), 2); // Round speed to 2 decimal places
    double pace = Math.Round(GetPace(), 2); // Round pace to 2 decimal places

    return $"{date.ToShortDateString()} Cycling ({minutes} min): Distance {distance} kilometers | Speed: {speed.ToString("0.##")} kph | Pace: {pace.ToString("0.##")} mins per km";
    // Use speed.ToString("0.##") and pace.ToString("0.##") to format with 2 decimal points
}
}