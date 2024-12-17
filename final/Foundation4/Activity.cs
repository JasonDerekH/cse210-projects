using System.Diagnostics;
using System.Runtime;

abstract class Activity
{
    public string date;
    public double duration;
    public Activity(string date,double duration)
    {
        this.date = date;
        this.duration = duration;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();


}