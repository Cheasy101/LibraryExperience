using LibraryExperience;
using LibraryExperience.Figures;

var circle = ShapeFactory.CreateShape("circle", 5);
var triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);

Console.WriteLine($"Circle area: {ShapeAreaCalculator.CalculateShapeArea(circle)}");
Console.WriteLine($"Triangle area: {ShapeAreaCalculator.CalculateShapeArea(triangle)}");

if (triangle is Triangle triangleShape)
{
    Console.WriteLine($"Is the triangle right-angled? {triangleShape.IsRightTriangle()}");
}