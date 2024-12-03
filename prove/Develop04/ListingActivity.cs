class ListingActivity : Activity
{
    private int numbResponses;
    private List<string> promptList = new List<string>{"When were moments that you felt the Holy Ghost this week?", 
    "What are some things you are grateful for? ", 
    "Looking back, when did you feel the happiest this week? ", 
    "What are some ways you could help others in need next week? ", 
    "What are some ways you were able to help others last week?"};
    private string prompt;
    public ListingActivity()
    {
        SetPrompt();
    }

    public void Welcome()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        SetDuration();

        GetReady();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");

        Console.Write("You may begin in: 5");
        for(int i = 0; i < 5;i++)
        {
            Thread.Sleep(1000);
            Console.Write($"\b{4-i}");
        }
        Console.WriteLine();


    }

    public void RunActivity()
    {
        DateTime currTime = DateTime.Now;
        DateTime futureTime = currTime.AddSeconds(duration);

        while(currTime < futureTime)
        {
            Console.ReadLine();
            numbResponses++;
            currTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {numbResponses} items!\n");
        Console.WriteLine($"Well Done!!\n\nYou have completed another {duration} seconds of the Listing Activity.");

        DisplayLoader();
        Console.Clear();
    }

    public void SetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(promptList.Count);
        prompt = promptList[index];


    }
}