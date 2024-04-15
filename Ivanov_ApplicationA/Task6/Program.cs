using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину стороны a=");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Высоту треугольника h=");
        double h = Convert.ToDouble(Console.ReadLine());

        double s =0.5 * a * h;
        Console.WriteLine($"Площадь треугольника:{s}"); ;
    }
}
