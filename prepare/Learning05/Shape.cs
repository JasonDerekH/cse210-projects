using System.Diagnostics.Tracing;

class Shape 
{
    private string color;

    public Shape()
    {
        
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }




}