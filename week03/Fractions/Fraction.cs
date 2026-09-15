public class Fraction
{
    private int _top;
    private int _botttom;

    public Fraction(int top, int bottom)
    {
        _top = top;
        _botttom = bottom;

    }
    public Fraction()
    {
        _top = 1;
        _botttom = 1;

    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _botttom = 1;
    }
    public Fraction(int top, int bottom, int wholeNumber)
    {
        _top = (wholeNumber * bottom) + top;
        _botttom = bottom;
    }
    public int GetTop()
    {
        return _top;

    }
    public void SetTop(int top)
    {
        _top = top;

    }
    public int GetBottom()
    {
        return _botttom;
    }
    public void SetBottom(int bottom)
    {
        _botttom = bottom;

    }
    
    public string GetFractionString()
    {
        return $"{_top}/{_botttom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / _botttom;
    }


    public void Display()
    {
        Console.WriteLine(GetFractionString());

        
    }



}