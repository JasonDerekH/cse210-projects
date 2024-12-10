class EternalGoal : Goal{

    public EternalGoal(string type)
    {
        this.type = type;
        GetName();
        GetDescription();
        GetPoints();
    }

    public EternalGoal(string type,string name,string description,string points)
    {
        this.type = type;
        this.name = name;
        this.description = description;
        this.points = int.Parse(points);
    }
    public override int AddPoints()
    {
        return points;
    }

    public override void GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }

    public override string ReturnInformation()
    {
        string data = type + "|";
        data += name + "|";
        data += description + "|";
        data += $"{points}";
        
        return data;
    }
}