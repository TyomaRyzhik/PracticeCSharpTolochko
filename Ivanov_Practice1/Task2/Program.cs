using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сторону a => ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите сторону b => ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите сторону c => ");
        int c = int.Parse(Console.ReadLine());

        if(a == b && b == c && a == c)
        {
            Console.WriteLine("Треугольник равносторонний");
        }
        else
        {
            Console.WriteLine("Треугольник не равносторонний");
        }
    }
}
