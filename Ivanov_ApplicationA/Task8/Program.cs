using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите радиус кргуа r=");
        double r = Convert.ToDouble(Console.ReadLine());

        double s = Math.PI * Math.Pow(r, 2);
        Console.Write($"Площадь круга:{s}");
    }
}
