using System;

public class Fraction{

    private int _top;
    private int _down;

    public Fraction()
    {
        _top = 1;
        _down = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _down = 1;
    }

    public Fraction(int top, int down){
        _down = down;
        _top = top;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_down}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_down;
    }
}
