using System;
public class Rectangle : Quadrilateral
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }

    public override double Area()
    {
        return Side1 * Side2;
    }
}