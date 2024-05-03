using System;

public delegate double Calculate(double value);

public class Square
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double Perimeter(double side)
    {
        return 4 * side;
    }

    public double Area(double side)
    {
        return side * side;
    }
}