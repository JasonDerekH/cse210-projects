using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        string response = Menu();
        while(int.Parse(response) > 0 && int.Parse(response) < 4)
        {
            if(response == "1")
            {
                BreathingActivity activity = new();
                activity.Welcome();
                activity.RunActivity();
            }
            else if(response == "2")
            {
                ReflectingActivity activity = new();
                activity.Welcome();
                activity.RunActivity();
            }
            else if(response == "3")
            {
                ListingActivity activity = new();
                activity.Welcome();
                activity.RunActivity();
            }
            response = Menu();
        }
    }

    static string Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity\n  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();
        return response;
        
    }
    
}

