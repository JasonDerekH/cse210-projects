using System.Diagnostics;

class Cycling : Activity{

    private double speed;

    public Cycling(string date, double duration, double speed) :base(date,duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed / 60 * duration;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{date} Cycling ({duration:F1} min): Distance {GetDistance():F1} miles, Speed {speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }

}