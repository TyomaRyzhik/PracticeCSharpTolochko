using System;
public class Program2
{
    public static void Main2()
    {
        Square square = new Square(5);
        Process(square.Perimeter, square.Side);
        Process(square.Area, square.Side);
    }

    public static void Process(Calculate calculate, double side)
    {
        Console.WriteLine($"Результат: {calculate(side)}");
    }
}
