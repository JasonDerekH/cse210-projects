class Program
{
    public static void Main(string[] args)
    {
        Assignment guy = new("Samuel Bennett","Multiplication");

        Console.WriteLine(guy.GetSummary());

        MathAssignment guy2 = new("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(guy2.GetSummary());
        Console.WriteLine(guy2.GetHomeworkList());

        WritingAssignment gal = new("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(gal.GetWritingInformation());
    }
}