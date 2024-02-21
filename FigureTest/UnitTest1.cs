using FigureLib;
using NUnit.Framework;

namespace FigureTest;


public class FigureTest
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.AreEqual(Math.PI * 25, circle.GetArea(), 0.001);
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.GetArea(), 0.001);
    }

    [Test]
    public void RightTriangleTest()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        Assert.IsTrue(rightTriangle.IsRightTriangle());

        var nonRightTriangle = new Triangle(3, 4, 6);
        Assert.IsFalse(nonRightTriangle.IsRightTriangle());
    }
}