using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference nephiScriptureReference = new Reference();
        nephiScriptureReference.DisplayScriptureReference();

        Scripture nephiScripture = new Scripture(nephiScriptureReference.GetWords());

        Scripture editedNephiScripture = new Scripture(nephiScripture.GetScripture());
        
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        string answer = Console.ReadLine();
        while(answer != "quit")
        {
            Console.Clear();
            editedNephiScripture.RemoveRandomWords();
            editedNephiScripture.DisplayScripture();
            
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();
        }
        
    }
}