using System.Configuration.Assemblies;
using System.IO.Enumeration;

class Journal
{
    //For stretch I could create a function to create a new journal
    //Give functions that will allow it to display, save, and etc
    private string fileName = "";
    private string userRequest;
    private List<Entry> entries;
    
    public Journal()
    {
        this.userRequest = "0";
        entries = new List<Entry>();
    }

//Function:Clears all the writing from a selected journal or clears your current entries before saving if 
//you put your fileName as "".
    public void ClearJournal()
    {
        Console.WriteLine("What file would you like to clear?(Type 'none' to clear current entries)");
        this.fileName = Console.ReadLine();

        if(fileName != "none")
        {
            using (StreamWriter writer = new StreamWriter(fileName, append: false))
            {
                //I don't do anything here, the file will automatically clear
            }
            Console.WriteLine($"{fileName} has been cleared.");
            
        }
        else
        {
            entries.Clear();
            Console.WriteLine("Your unsaved entries have been cleared.");
            fileName = "";
        }
        
        
    }
    //AddEntry function to add Entry to list of Entries
    public void AddEntry(Entry entry)
    {
        this.entries.Add(entry);
    }
    //Function to set fileName after asking user for which file to load
    public void LoadFile()
    {
        Console.WriteLine("What is the filename? ");
        this.fileName = Console.ReadLine();
    }
    public void SaveFile()
    {
        Console.WriteLine("What is the filename? ");
        this.fileName = Console.ReadLine();

        using(StreamWriter writer = new StreamWriter(this.fileName, append: true))
        {
            foreach(Entry entry in this.entries)
            {
                writer.WriteLine(entry.GetEntry());
            }
        }
        entries.Clear();
        fileName = "";
    }
    //DisplayJournal() goes through and displays each entry from entries separated by a line
    public void DisplayJournal()
    {

        if(fileName == "")
        {
            foreach (Entry entry in entries)
            {
                
                Console.WriteLine(entry.GetEntry());
                Console.WriteLine();

            }
        }
        else
        {
            using(StreamReader reader = new StreamReader(fileName))
            {
                string currentLine;

                while((currentLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(currentLine);
                }
            }
        }
    }
    //executeChoice(string choice) takes user input from the menu and acts accordingly.
    public void ExecuteChoice()
    {
        if(userRequest == "1")
            {
                Entry myEntry = new Entry();
                myEntry.PromptUser();
                myEntry.FormEntry();
                Console.WriteLine(myEntry.GetEntry());
                entries.Add(myEntry);
            }
            else if(userRequest == "2")
            {
                //Comment out line below later
                
                DisplayJournal();
            }
            else if(userRequest == "3")
            {
                LoadFile();
            }
            else if(userRequest == "4")
            {
                SaveFile();
            }
            else if(userRequest == "5")
            {
                ClearJournal();
            }
        
    }
    //^^Could combine with above line: Function to print the menu of options.
    public void PrintMenu()
    {
        userRequest = "0";
        while(userRequest != "6")
        {
        
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear Journal");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            userRequest = Console.ReadLine();
            if(userRequest != "6")
            {
                this.ExecuteChoice();
            }
            
        }

    }


}