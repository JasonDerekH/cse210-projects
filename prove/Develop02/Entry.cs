
//I used ChatGPT to help me come up with random prompts to ask the user. I came up with 
//the programming itself.

using System.Collections.Generic;
class Entry
{
    //Constant variable that holds the various prompts
    private List<string> promptsList = new List<string>()
    {
        "What moment from today made you smile the most and why?", 
        "If you could give today a theme, what would it be and why?", 
        "What's one thing you learned about yourself this week?",
        "Describe a moment of unexpected joy you experienced recently.", 
        "What's one thing you're looking forward to, and how does it make you feel?", 
        "Write about a challenge you faced today and how you overcame it.", 
        "What's one thing you wished more people knew about you?", 
        "Reflect on a small victory from today and how it impacted your mood." 
    };
    private string dateText;

    private string prompt;
    private string writing;
    private string wholeEntry;
    


    public Entry()
    {
        dateText = DateTime.Now.ToShortDateString();
        
        
        //Randomly generate a prompt from a list of prompts
        Random randomizer = new Random();
        int randomIndex = randomizer.Next(promptsList.Count);
        prompt = promptsList[randomIndex];


        
    }

    public string GetEntry()
    {
        return wholeEntry;
    }

    public void FormEntry()
    {
        wholeEntry = ($"Date: {dateText} - Prompt: {prompt}\n{writing}"); //<-- Insert the prompt
    }

    public void DisplayEntry()
    {
        Console.WriteLine(wholeEntry);
    }

    public void PromptUser() //could replace void with string to return user input
    {
        Console.WriteLine(prompt);
        writing = Console.ReadLine();
    }

    //Example of syntax order:
    //PromptUser, FormEntry, GetEntry/Display Entry

}