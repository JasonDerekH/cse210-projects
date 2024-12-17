using System.Diagnostics;

class Running : Activity{

    private double distance;

    public Running(string date, double duration, double distance) :base(date,duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / duration * 60;
    }

    public override double GetPace()
    {
        return duration / distance;
    }

    public override string GetSummary()
    {
        return $"{date} Running ({duration:F1} min): Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

}