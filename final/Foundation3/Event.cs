abstract class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;
    
    public Event(string title,string description,string date,string time,string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetDescription()
    {
        return description;
    }
    public string GetDate()
    {
        return date;
    }

    public string GetTime()
    {
        return time;
    }

    public string GetAddress()
    {
        return address;
    }

    public void DisplayStandard()
    {
        Console.WriteLine("Standard Event Information: ");
        Console.WriteLine($"{title} ({description}) will occur on {date} at {time}\nLocation: {address}\n");
    }

    public abstract void DisplayFull();

    public abstract void DisplayShort();

    

}