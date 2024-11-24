using System.Globalization;
using System.Reflection.Metadata;

class Scripture
{
    private List<Word> scripture = new List<Word>();
    private int scriptureLength;
    public Scripture(List<Word> scripture)
    {
        this.scripture = scripture;
        scriptureLength = scripture.Count;
    }

    public override string ToString()
    {
        string scriptureString = "";
        foreach(Word word in scripture)
        {
            scriptureString += $" {word.GetText()}";
        }
        return scriptureString;
    }

    public List<Word> GetScripture()
    {
        return scripture;
    }

    public List<Word> RemoveRandomWords()
    {
        List<Word> editedScripture = new List<Word>();
        editedScripture = scripture;

        Random random = new Random();
        List<int> indexesToRemove = new List<int>();
        indexesToRemove = Enumerable.Range(0, scripture.Count) //Makes a range with all the valid indexes.
            .OrderBy(x => random.Next())  //Randomizes order
            .Take(3)   //3 is the number I chose for words to take out.
            .ToList(); //turns it to a list
        
        foreach(int index in indexesToRemove)
        {
            editedScripture[index].SetBlank();
        }

        
        return editedScripture;
    }

    public void DisplayScripture()
    {
        //Change Line Below <---
        Console.Write($"3 Nephi 32:3 ");
        foreach(Word word in scripture)
        {
            Console.Write($" {word}");
        }
        Console.WriteLine();

    }
}