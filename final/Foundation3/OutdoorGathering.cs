using System.Reflection;

class OutdoorGathering : Event
{
    private string weather;
    private string type;
    public OutdoorGathering(string title,string description,string date,string time,string address, string weather, string type) :base(title,description,date,time,address)
    {
        this.weather = weather;
        this.type = type;
    }

    public override void DisplayShort()
    {
        Console.WriteLine($"Brief {type} Information:");
        Console.WriteLine($"{GetTitle()} will happen on {GetDate()}\n");
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"Full {type} Information");
        Console.WriteLine($"It will be {weather} on {GetDate()} at {GetTime()}");
        Console.WriteLine($"{GetTitle()} ({GetDescription()}) will happen at {GetAddress()}\n");
    }
}