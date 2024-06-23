using LibraryExperience.Figures;

namespace LibraryExperience;

public static class ShapeFactory
{
    public static IShape CreateShape(string shapeType, params double[] parameters)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                if (parameters.Length != 1)
                    throw new ArgumentException("Circle requires only radius");
                return new Circle(parameters[0]);
            case "triangle":
                if (parameters.Length != 3)
                    throw new ArgumentException("Circle requires three parameters");
                return new Triangle(parameters[0], parameters[1], parameters[2]);
            default:
                throw new ArgumentException("Invalid shape type");
        }
    }
}