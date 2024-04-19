using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = CalculateFunction(x);
            Console.WriteLine($"Значение функции f при x={x} равно {y}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное число.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: попытка деления на ноль.");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        Console.Read();
    }

    static double CalculateFunction(double x)
    {
        if (x > -4 && x <= 1)
        {
            if (4 * x + 4 == 0)
            {
                throw new DivideByZeroException();
            }
            return (3 * x + 2) / (4 * x + 4);
        }
        else if (x > 1)
        {
            return x * x;
        }
        else
        {
            throw new ArgumentOutOfRangeException("x", "Значение x выходит за допустимый диапазон (-4 < x).");
        }
    }
}
