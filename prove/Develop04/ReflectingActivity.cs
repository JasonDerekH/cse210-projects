class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>{"> Look around and find something that makes you smile.", 
    "> Touch an object near you. How would you describe its texture?", 
    "> Think of one word that describes how you felt today.",
    "> Pick a color and quickly identify three things around you in that color.", 
    "> What's the last thing you ate or drank? Can you recall its taste?", 
    "> Take a moment to notice the light around you. Is it bright, dim, or dark?", 
    "> Recall one thing that went well for you today, no matter how small.", 
    "> Gently tap your fingers on something nearby. Notice the rhythm and feeling."};

    private string currPrompt;
    public ReflectingActivity()
    {
        GetPrompt();
    }

    public void GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        currPrompt = prompts[index];

    }

    public void Welcome()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you be more aware of your surroundings. This will sharpen your senses and help you feel a greater presence in your surroundings.\n");
        SetDuration();
        GetReady();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(" --- Take a deep inhale and smell the air around you. How would you describe it? ---\n");

        Console.WriteLine("When you're done pondering, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following prompts as they relate to this experience.");
        Console.Write("You may begin in: 5");
        for(int i = 0; i < 5;i++)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{4-i}");
        }
        Console.Clear();

    }

    public void RunActivity()
    {
        DateTime currTime = DateTime.Now;
        DateTime futureTime = currTime.AddSeconds(duration);
        while(currTime < futureTime)
        {
            Console.Write($"{currPrompt} ");
            
            DisplayLoaderLonger();
            Console.WriteLine();
            GetPrompt();

            currTime = DateTime.Now;
        }

        Console.WriteLine("\nWell done!!\n");

        Console.WriteLine($"You have completed another {duration} of the Reflecting Activity.");
        DisplayLoader();
        
    }
}