class Word
{
    private string text;
    private bool isHidden = false;
    public Word(string text)
    {
        this.text = text;
    }

    public void SetBlank()
    {
        text = "____";
        isHidden = true;
    }
    public override string ToString()
    {
        return text;
    }
    //Not sure if I need the GetText function anymore but I'll keep it in case.
    public string GetText()
    {
        return text;
    }
}