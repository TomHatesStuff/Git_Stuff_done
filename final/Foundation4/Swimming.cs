class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return Minutes > 0 ? GetDistance() / Minutes * 60 : 0;
    }

    public override double GetPace()
    {
        return GetSpeed() > 0 ? 60 / GetSpeed() : double.PositiveInfinity;
    }
}