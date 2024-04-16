using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите x => ");
        double x = int.Parse(Console.ReadLine());
        double y;
        if (x > 6.7)
        {
            y = 4 - Math.Pow(Math.E, 4 * x);
            Console.WriteLine($"Функция равна:={y}");
        }
        else
        {
            y = Math.Log10(3.5 + x);
            Console.WriteLine($"Функция равна:={y}");
        }
    }
}
