public class Square : Shape
{
    private double _sideLength;
    public double SideLength
    {
        get {return _sideLength;}
        set {_sideLength = value;}

    }
    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}