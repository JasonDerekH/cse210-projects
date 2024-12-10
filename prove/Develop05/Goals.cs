using System.ComponentModel.Design;

class Goals
{
    private List<Goal> goals;
    private int totalPoints;
    private int goalCount;
    private string fileName;
    private string type;

    public Goals()
    {
        
        goals = new List<Goal>();
        goalCount = 0;
        
    }

    public void GetFileName()
    {
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        goalCount++;
    }

    public void SaveGoals()
    {
        GetFileName();
        string[] data = new string[goalCount+1];
        data[0] = $"{totalPoints}";
        int counter = 1;
        foreach(Goal goal in goals)
        {
            string goalData = "";
            goalData += goal.ReturnInformation();
            data[counter] = goalData;
            counter++;
        }

        using(StreamWriter writer = new StreamWriter(fileName))
        {
            foreach(string line in data)
            {
                writer.WriteLine(line);
            }
        }


    }

    public void LoadGoals()
    {
        GetFileName();
        goals.Clear();
        using(StreamReader reader = new StreamReader(fileName))
        {
            string line;
            totalPoints = int.Parse(reader.ReadLine());
            while((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if(parts[0] == "Simple")
                {
                    goals.Add(new SimpleGoal(parts[0],parts[1],parts[2],parts[3],parts[4]));
                }
                else if(parts[0] == "Eternal")
                {
                    goals.Add(new EternalGoal(parts[0],parts[1],parts[2],parts[3]));
                }
                else
                {
                    goals.Add(new ChecklistGoal(parts[0],parts[1],parts[2],parts[3],parts[4],parts[5],parts[6]));
                }

            }
        }

    }

    public void MainMenu()
    {
        bool isRunning = true;
        while(isRunning == true)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if(response == "1")
            {
                GetGoalType();
                if(type == "Simple")
                {
                    SimpleGoal goal = new(type);
                    AddGoal(goal);
                }
                else if(type == "Eternal")
                {
                    EternalGoal goal = new(type);
                    AddGoal(goal);
                }
                else if(type == "Checklist")
                {
                    ChecklistGoal goal = new(type);
                    AddGoal(goal);
                }
            }
            else if(response == "2")
            {
                DisplayGoals();
            }
            else if(response == "3")
            {
                SaveGoals();
            }
            else if(response == "4")
            {
                LoadGoals();
            }
            else if(response == "5")
            {
                RecordEvent();
            }
            else if(response == "6")
            {
                isRunning = false;
            }
        }


        
        
    
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());

        int addedPoints = goals[index-1].AddPoints();
        totalPoints += addedPoints;

        Console.WriteLine($"Congratulations! You have earned {addedPoints} points!");
        Console.WriteLine($"You now have {totalPoints} points.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int counter = 0;
        foreach(Goal goal in goals)
        {
            Console.Write($"{counter + 1}. ");
            goal.DisplayGoal();

            counter++;
        }
    }

    public void GetGoalType()
    {
        Console.WriteLine("Goal Options:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string response = Console.ReadLine();

        if(response == "1")
        {
            type = "Simple";
        }
        else if(response == "2")
        {
            type = "Eternal";
        }
        else if(response == "3")
        {
            type = "Checklist";
        }
    }

    
}