namespace ExerciseTracker
{
    public abstract class Activity
    {
        public DateTime Date { get; private set; }
        public int Duration { get; private set; } // Duration in minutes

        public Activity(DateTime date, int duration)
        {
            Date = date;
            Duration = duration;
        }

        public abstract double GetDistance(); // In kilometers or miles
        public abstract double GetSpeed(); // In kph or mph
        public abstract double GetPace(); // In minutes per km or mile

        public string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Duration} min): " +
                   $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }
}