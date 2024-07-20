namespace ExerciseTracker
{
public class Swimming : Activity
{
    public int Laps { get; private set; }
    private const double LapDistanceKm = 50.0 / 1000.0; // Each lap is 50 meters

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapDistanceKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}
}