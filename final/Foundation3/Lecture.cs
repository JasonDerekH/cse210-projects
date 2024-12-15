class Lecture : Event
{
    private string speaker;
    private string type;
    private int capacity;
    public Lecture(string title,string description,string date,string time,string address, string speaker, int capacity, string type) :base(title,description,date,time,address)
    {
        this.speaker = speaker;
        this.type = type;
        this.capacity = capacity;
    }

    public string GetSpeaker()
    {
        return speaker;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public string GetEventType()
    {
        return type;
    }

    public override void DisplayShort()
    {
        Console.WriteLine($"Brief {type} Information:");
        Console.WriteLine($"{GetTitle()} will occur on {GetDate()}\n");
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Full {type} Information:");
        Console.WriteLine($"{speaker} will speak {GetDate()} for the {GetTitle()} ({GetDescription()})");
        Console.WriteLine($"The event will happen {GetTime()} at {GetAddress()}\n");
    }
}