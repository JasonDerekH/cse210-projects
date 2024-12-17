using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running("17 Dec 2024",19.45,3.0);
        Activity cycling = new Cycling("19 Dec 2024",32.5,24.3);
        Activity swimming = new Swimming("07 May 2024",17.6,20);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}