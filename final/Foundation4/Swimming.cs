class Swimming : Activity{
    private double lapCount;
    public Swimming(string date, double duration, double lapCount) :base(date,duration)
    {
        this.lapCount = lapCount;
    }

    public override double GetDistance()
    {
        return lapCount * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / duration * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{date} Swimming ({duration:F1} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile, Laps Completed: {lapCount:F1}";
    }
}