class Reference
{
    private Dictionary<string,List<Word>> scriptureReferences = new Dictionary<string, List<Word>>();
    
    private string reference;
    public Reference()
    {
        scriptureReferences["3 Nephi 32:3"] = new List<Word> {new Word("Angels"), new Word("speak"), 
        new Word("by"), new Word("the"), new Word("power"), new Word("of"), new Word("the")
        , new Word("Holy"), new Word("Ghost;"), new Word("wherefore,"), new Word("they"), new Word("speak")
        , new Word("the"), new Word("words"), new Word("of"), new Word("Christ."), new Word("Wherefore,")
        , new Word("I"), new Word("said"), new Word("unto"), new Word("you,"), new Word("feast")
        , new Word("upon"), new Word("the"), new Word("words"), new Word("of"), new Word("Christ;")
        , new Word("for"), new Word("behold,"), new Word("the"), new Word("words"), new Word("of")
        , new Word("Christ"), new Word("will"), new Word("tell"), new Word("you"), new Word("all")
        , new Word("things"), new Word("what"), new Word("ye"), new Word("should"), new Word("do.")};

        //Default value for testing purposes
        reference = "3 Nephi 32:3";
        //Needs to go in scripture class: scriptureLength = scriptureReferences["3 Nephi 32:3"].Count;
    }

    public void SetRandomReference()
    {
        //Will be helpful if I decide to let the program pick a random sripture.
        Random randomizer = new Random();
        var keys = new List<string>(scriptureReferences.Keys);
        int randomIndex = randomizer.Next(keys.Count);
        reference = keys[randomIndex];
    }

    public List<Word> GetWords()
    {
        return scriptureReferences[reference];
    }
    public string GetScripture()
    {
        string scriptureString = "";
        foreach(Word word in scriptureReferences["3 Nephi 32:3"])
        {
            scriptureString += word.GetText();
        }
        return scriptureString;
    }

    public void DisplayScriptureReference()
    {
        Console.Write($"{reference}");
        foreach(Word word in scriptureReferences[reference])
        {
            Console.Write($" {word}");
        }
        Console.WriteLine();

    }


}