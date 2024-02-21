namespace FigureLib;

public class Triangle(double side3, double side2, double side1) : Figure
{
    private double _side1 = side1;
    private double _side2 = side2;
    private double _side3 = side3;

    public override double GetArea()
    {
        var s = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }
    
    public bool IsRightTriangle()
    {
        var sides = new[] { _side1, _side2, _side3 };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) == 0;
    }
}