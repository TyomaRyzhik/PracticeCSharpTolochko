using System;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение h (шаг): ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nТаблица значений функции f(x) = y:");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("|{0,10}|{1,10}|", "x", "y");
        Console.WriteLine("-------------------------------");

        for (double x = a; x <= b; x += h)
        {
            double y = Function(x, a, b);
            Console.WriteLine("|{0,10}|{1,10}|", x, y);
        }

        Console.WriteLine("-------------------------------");
        Console.Read();
    }

    /// <summary>
    /// Функция для вычисления значения y в зависимости от x, a и b.
    /// </summary>
    /// <param name="x">Значение x.</param>
    /// <param name="a">Значение a.</param>
    /// <param name="b">Значение b.</param>
    /// <returns>Возвращает значение y.</returns>
    static double Function(double x, double a, double b)
    {
        if (x < 0)
        {
            return ((b * x - 1) / a) * x;
        }
        else if (x >= 0 && x <= 3)
        {
            return ((b * x + 1) / a) * x;
        }
        else // x > 3
        {
            return ((b * x + 1) / a) * x - 1;
        }
    }
}
