using System.ComponentModel;
using System.Runtime.InteropServices;

class BreathingActivity : Activity
{
    private int inhaleTime;
    private int exhaleTime;
    //For stretch I could include a function to calculate best inhale and exhale times.
    public BreathingActivity()
    {

    }

    public void Welcome()
    {
        Console.WriteLine("Welcome to the Breathing Activity!\n");

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        SetDuration();
    }
    public void BreatheIn()
    {
        //Based on time frame, it will space the breaths differently. As well as randomizes it a bit.
        if(duration % 6 == 0)
        { 
            inhaleTime = 2;
        }
        else if(duration % 8 == 0)
        {
            inhaleTime = 3;
        }
        else{
            inhaleTime = 4;
        }
        Console.Write($"Breathe in...{inhaleTime}");
            Thread.Sleep(1000);
            for(int i = 0; i < inhaleTime;i++)
            {
                Console.Write($"\b{inhaleTime-1-i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
    }

    public void BreatheOut()
    {
        //Based on time frame, it will space the breaths differently. As well as randomizes it a bit.
        if(duration % 6 == 0)
        { 
            exhaleTime = 4;
        }
        else if(duration % 8 == 0)
        {
            inhaleTime = 5;
        }
        else{
            inhaleTime = 6;
        }
        Console.Write($"Now breathe out...{exhaleTime}");
        Thread.Sleep(1000);
        for(int i = 0; i < exhaleTime; i++)
        {
            Console.Write($"\b{exhaleTime-1-i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void RunActivity()
    {
        Console.WriteLine("Get Ready...\n\n");
        DisplayLoader();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(duration);

        while(currentTime < futureTime)
        {
            BreatheIn();
            BreatheOut();
            
            currentTime = DateTime.Now;

        }

        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        DisplayLoader();
        Console.Clear();
    }
}