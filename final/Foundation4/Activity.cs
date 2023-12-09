class Activity
{
    private DateTime date;
    private int minutes;

    protected int Minutes => minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string distanceUnit = distance > 0 ? "mile" : "km";
        string paceUnit = distance > 0 ? "min/mile" : "min/km";

        string paceString = double.IsInfinity(pace) ? "N/A" : $"{pace:F2}";

        return $"{date:d} {GetType().Name} ({minutes} min) - Distance: {distance:F2} miles, Speed: {speed:F2} mph, Pace: {paceString} {paceUnit}";
    }
}