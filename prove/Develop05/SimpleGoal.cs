class SimpleGoal : Goal
{
    private bool isCompleted;
    public SimpleGoal(string type)
    {
        this.type = type;
        GetName();
        GetDescription();
        GetPoints();

        isCompleted = false;
    }

    public SimpleGoal(string type,string name,string description,string points, string isCompleted)
    {
        this.type = type;
        this.name = name;
        this.description = description;
        this.points = int.Parse(points);
        this.isCompleted = Convert.ToBoolean(isCompleted);
    }

    public void SetComplete()
    {
        isCompleted = true;
    }

    public override void GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }

    public override int AddPoints()
    {
        if(isCompleted)
        {
            return points;
        }
        else{
            isCompleted = true;
            return points;
        }
    }

    public override void DisplayGoal()
    {
        if(isCompleted)
        {
            Console.WriteLine($"[X] {name} ({description})");
        }
        else
        {
            Console.WriteLine($"[ ] {name} ({description})");
        }
        
    }

    public override string ReturnInformation()
    {
        string data = type + "|";
        data += name + "|";
        data += description + "|";
        data += $"{points}|{isCompleted}";
        
        return data;
    }


}