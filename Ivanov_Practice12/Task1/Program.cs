using System;

public delegate double CalcFigure(double r);

public static class Geometry
{
    public static double Get_Length(double r)
    {
        return 2 * Math.PI * r;
    }

    public static double Get_Area(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    public static double Get_Volume(double r)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double r = 5;
        CalcFigure CF = Geometry.Get_Length;
        Console.WriteLine($"Circle length: {CF(r)}");
        CF = Geometry.Get_Area;
        Console.WriteLine($"Circle area: {CF(r)}");
        CF = Geometry.Get_Volume;
        Console.WriteLine($"Sphere volume: {CF(r)}");
        Console.ReadLine();
    }
}
