class Video
{
    private string title;
    private string author;
    private int length;
    List<Comment> comments = new List<Comment>();
    public Video(string title,string author,int length,List<Comment> comments)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = comments;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetLength()
    {
        return length;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public override string ToString()
    {
        string display = "";
        display += $"\"{title}\" by {author}: ({length} seconds)\nComments:\n";
        foreach (Comment comment in comments)
        {
            display += $"  \"{comment.GetText()}\" from {comment.GetWriter()}\n";
        }
        return display;
    }
}