class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return Minutes > 0 ? speed : 0;
    }

    public override double GetDistance()
    {
        return GetSpeed() * Minutes / 60;
    }

    public override double GetPace()
    {
        return GetSpeed() > 0 ? 60 / GetSpeed() : double.PositiveInfinity;
    }
}