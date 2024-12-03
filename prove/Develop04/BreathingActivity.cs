using System.ComponentModel;
using System.Runtime.InteropServices;

class BreathingActivity : Activity
{

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
        //Displays breath in prompt
        Console.Write("Breathe in...4");
        Thread.Sleep(1000);
        for(int i = 0; i < 4;i++)
        {
            Console.Write($"\b{3-i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Now breathe out...6");
        Thread.Sleep(1000);
        for(int i = 0; i < 6; i++)
        {
            Console.Write($"\b{5-i}");
            Thread.Sleep(1000);
        }
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