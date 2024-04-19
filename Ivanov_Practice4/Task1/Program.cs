using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            if (x == -8)
            {
                throw new DivideByZeroException();
            }
            double y = (x + 4) / (x + 8);
            Console.WriteLine($"y = (x + 4) / (x + 8) = {y}");

            if (x == 1)
            {
                throw new DivideByZeroException();
            }
            y = Math.Pow(Math.Cos(x), 3) / (x - 1);
            Console.WriteLine($"y = cos^3(x) / (x - 1) = {y}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Нужно ввести число!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Делить на нуль нельзя!");
        }
        Console.Read();
    }
}
