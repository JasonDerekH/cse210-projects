using System;
using System.Linq.Expressions;

class Assignment
{
    protected string name;
    private string topic;

    public Assignment(string name, string topic)
    {
        this.name = name;
        this.topic = topic;
    }

    public string GetSummary()
    {
        return $"{name} - {topic}";
    }


}