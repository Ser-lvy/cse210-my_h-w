using System.Drawing;

public class Shape
{
    private string _color = "color";

    public string Color
    {
        get { return _color;}
        set {_color = value;}
    }

    public virtual double GetArea()
    {
        return 0;
    }

}