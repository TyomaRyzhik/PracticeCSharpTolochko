using System;
public class Square : Quadrilateral
{
    public double Side { get; set; }

    public override double Area()
    {
        return Side * Side;
    }
}