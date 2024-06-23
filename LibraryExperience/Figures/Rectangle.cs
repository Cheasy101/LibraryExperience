namespace LibraryExperience.Figures;

public class Rectangle(double length, double width) : IShape
{
    public double Length { get; private set; } = length;
    public double Width { get; private set; } = width;

    public double CalculateArea()
    {
        return Length * Width;
    }

    public bool IsSquare()
    {
        return Length.Equals(width);
        //можно и ==
    }
}