using System;
using System.IO;
using System.Linq;

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
        string filePath = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task1\\f.txt";
        var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

        double maxNumber = numbers.Max();
        double minNumber = numbers.Min();

        double sum = maxNumber + minNumber;

        Console.WriteLine($"Сумма наибольшего и наименьшего числа: {sum}");

        Console.ReadLine();
    }
}
