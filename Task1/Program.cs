using System;

public class Program
{
    public static void Main()
    {
        Square square = new Square(5);
        Calculate calculate = square.Perimeter;
        Console.WriteLine($"Периметр квадрата: {calculate(square.Side)}");
        calculate = square.Area;
        Console.WriteLine($"Площадь квадрата: {calculate(square.Side)}");
        Console.ReadLine();
    }
}