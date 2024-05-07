public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        else
        {
            throw new ArgumentException("A triangle with these sides does not exist.");
        }
    }

    public override double Area()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public override double Perimeter()
    {
        return SideA + SideB + SideC;
    }

    public string Type()
    {
        if (SideA == SideB && SideB == SideC)
        {
            return "Equilateral";
        }
        else if (SideA == SideB || SideA == SideC || SideB == SideC)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
}
