using LibraryExperience.Figures;

namespace LibraryExperience;

public static class ShapeAreaCalculator
{
    public static double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}