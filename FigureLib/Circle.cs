namespace FigureLib;

public class Circle(float radius) : Figure
{
    private double _radius = radius;

    public override double GetArea() => Math.PI * Math.Pow(_radius, 2f);
}