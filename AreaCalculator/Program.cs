using LibraryExperience;
using LibraryExperience.Figures;

var circle = ShapeFactory.CreateShape("circle", 5);
var triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);

// во втором коммите специально подобным образом создал квадрат.
// чтобы по изменениям было видно насколько быстро в библиотеку можно добавить новую фигуру
// если дальше продолжать дорабатывать, то так-же можно в фабрику добавить создание квадрата если нужно.    
var rectangle = new Rectangle(2,2);  
Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
Console.WriteLine($"Is the rectangle a square? {rectangle.IsSquare()}");

Console.WriteLine($"Circle area: {ShapeAreaCalculator.CalculateShapeArea(circle)}");
Console.WriteLine($"Triangle area: {ShapeAreaCalculator.CalculateShapeArea(triangle)}");

if (triangle is Triangle triangleShape)
{
    Console.WriteLine($"Is the triangle right-angled? {triangleShape.IsRightTriangle()}");
}