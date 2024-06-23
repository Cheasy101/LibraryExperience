using LibraryExperience;
using LibraryExperience.Figures;

namespace CalculatorTests;

public class ShapeAreaTests
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void TriangleIsRightAngledTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRightTriangle(), Is.True);
    }

    [Test]
    public void ShapeFactoryCircleTest()
    {
        var shape = ShapeFactory.CreateShape("circle", 5);
        Assert.That(shape, Is.InstanceOf<Circle>());
        Assert.That(shape.CalculateArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void ShapeFactoryTriangleTest()
    {
        var shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);
        Assert.That(shape, Is.InstanceOf<Triangle>());
        Assert.That(shape.CalculateArea(), Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void CalculateShapeAreaTest()
    {
        IShape circle = ShapeFactory.CreateShape("circle", 5);
        IShape triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);

        Assert.That(ShapeAreaCalculator.CalculateShapeArea(circle), Is.EqualTo(Math.PI * 25).Within(1e-10));
        Assert.That(ShapeAreaCalculator.CalculateShapeArea(triangle), Is.EqualTo(6).Within(1e-10));
    }
}