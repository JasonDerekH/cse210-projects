class Fraction
{
    private int top;
    private int bot;
    public Fraction()
    {
        top = 1;
        bot = 1;
    }

    public Fraction(int top)
    {
        this.top = top;
        bot = 1;
    }

    public Fraction(int top, int bot)
    {
        this.top = top;
        this.bot = bot;
    }

    public int GetTop()
    {
        return top;
    }

    public int GetBot()
    {
        return bot;
    }

    public string GetFractionString()
    {
        return $"{top}/{bot}";
    }

    public double GetDecimalValue()
    {
        double topDouble = top;
        double botDouble = bot;
        return topDouble / botDouble;
    }
}