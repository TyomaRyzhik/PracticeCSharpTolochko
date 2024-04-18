using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a1: ");
        int a1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение a2: ");
        int a2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение c2: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        int result = SubMod(a1, b1) + SubMod(a2, b2, c2);
        Console.WriteLine("Результат: " + result);

        Console.ReadLine();
    }

    static int SubMod(int a, int b)
    {
        return Math.Abs(a - b);
    }

    static int SubMod(int a, int b, int c)
    {
        return Math.Abs(a - b - c);
    }
}
