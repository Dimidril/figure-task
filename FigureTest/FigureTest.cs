using FigureLib;

namespace FigureTest;

public class FigureTest
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25));
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.GetArea(), Is.EqualTo(6));
    }

    [Test]
    public void RightTriangleTest()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        Assert.That(rightTriangle.IsRightTriangle(), Is.True);

        var nonRightTriangle = new Triangle(3, 4, 6);
        Assert.That(nonRightTriangle.IsRightTriangle(), Is.False);
    }
}