class ChecklistGoal : Goal
{
    private int bonusPoints;
    private int taskCount;
    private int currentTasks;
    public ChecklistGoal(string type)
    {
        this.type = type;
        GetName();
        GetDescription();
        GetPoints();

        currentTasks = 0;
    }

    public ChecklistGoal(string type,string name,string description,string points, string bonusPoints,string taskCount,string currentTasks)
    {
        this.type = type;
        this.name = name;
        this.description = description;
        this.points = int.Parse(points);
        this.bonusPoints = int.Parse(bonusPoints);
        this.taskCount = int.Parse(taskCount);
        this.currentTasks = int.Parse(currentTasks);
    }
    public override void GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        taskCount = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int AddPoints()
    {
        int total = points;
        currentTasks++;
        if(taskCount == currentTasks)
        {
            total += bonusPoints;
            return total;
        }
        else{
            return total;
        }
    }

    public override void DisplayGoal()
    {
        if(currentTasks < taskCount)
        {
            Console.WriteLine($"[ ] {name} ({description}) -- Currently completed: {currentTasks}/{taskCount}");
        }
        else if(currentTasks >= taskCount)
        {
            Console.WriteLine($"[X] {name} ({description}) -- Completed: {currentTasks}/{taskCount}");
        }
        
    }

    public override string ReturnInformation()
    {
        string data = type + "|";
        data += name + "|";
        data += description + "|";
        data += $"{points}|{bonusPoints}|{taskCount}|{currentTasks}";
        
        return data;
    }


}