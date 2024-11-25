class MathAssignment : Assignment
{
    private string section;
    private string problems;
    public MathAssignment(string name, string topic, string section, string problems) :base(name,topic)
    {
        this.section = section;
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {section} - Problems {problems}";
    }



    
}