using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("X = 1");
        double x = 1;
        double y = Math.Log(2 * x) + (Math.Pow(Math.Sin(x), 2) + 0.5 * Math.Sqrt(Math.Pow(Math.E, 2) + 1) - Math.Cos(x - Math.PI));
        Console.WriteLine(y);
    }
}
