using System.Reflection.PortableExecutable;

abstract class Goal{

    protected string name;
    protected string description;
    protected int points;
    protected string type;
    public Goal()
    {
        
        
        
    }

    public void GetName()
    {
        Console.Write("What is the name of your goal?");
        name = Console.ReadLine();
    }

    public abstract string ReturnInformation();

    public void GetDescription()
    {
        Console.Write("What is a short description of it?");
        description = Console.ReadLine();
    }

    public void GetGoalType()
    {
        Console.Write("Which type of goal would you like to create? ");
        string response = Console.ReadLine();

        if(response == "1")
        {
            type = "Simple";
        }
        else if(type == "2")
        {
            type = "Eternal";
        }
        else if(type == "3")
        {
            type = "Checklist";
        }
    }

    public abstract void GetPoints();
    //Prompt will look like this: "What is the amount of points associated with this goal? "

    public abstract int AddPoints();

//Default method for displaying a goal for EternalGoal
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {name} ({description})");
    }

}
