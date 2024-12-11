class Comment
{
    private string writer;
    private string text;
    public Comment(string writer, string text)
    {
        this.writer = writer;
        this.text = text;

    }

    public string GetText()
    {
        return text;
    }

    public string GetWriter()
    {
        return writer;
    }
}