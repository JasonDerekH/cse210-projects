public class Activity{
    protected string description;
    protected int duration;

    public Activity()
    {

    }
    public void DisplayLoader(bool loadBrief = true)
    {
        while(loadBrief)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
                Console.Write("\b|");
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.Write("\b");
            loadBrief = false;
            
        }
        
        //Might include another long loop if I need it.
        Console.Write("\b");
    }

    public void DisplayLoaderLonger()
    {
        while(!Console.KeyAvailable)
        { 
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write("\b");
        Console.ReadKey();
    }

    public void GetReady()
    {
        Console.WriteLine("Get Ready...\n\n");
        DisplayLoader();
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }
}