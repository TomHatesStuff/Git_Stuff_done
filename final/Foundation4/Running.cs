class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return Minutes > 0 ? distance / Minutes * 60 : 0;
    }

    public override double GetPace()
    {
        return GetSpeed() > 0 ? 60 / GetSpeed() : double.PositiveInfinity;
    }
}