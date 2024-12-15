class Reception : Event{
    private string email;
    private string type;
    public Reception(string title,string description,string date,string time,string address, string email, string type) :base(title,description,date,time,address)
    {
        this.email = email;
        this.type = type;
    }

    public string GetEmail()
    {
        return email;
    }
    public override void DisplayShort()
    {
        Console.WriteLine($"Brief {type} Information:");
        Console.WriteLine($"{GetTitle()} will happen on {GetDate()}\n");
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"Full {type} Information:");
        Console.WriteLine($"{GetTitle()} ({GetDescription()}) is inviting everyont to RSVP to {email}");
        Console.WriteLine($"The event reception will happen {GetTime()} on {GetDate()} at {GetAddress()}\n");
    }
}