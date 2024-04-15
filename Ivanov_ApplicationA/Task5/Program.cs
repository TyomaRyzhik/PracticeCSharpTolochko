using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите расстояние в верстах: ");
        double verst = Convert.ToDouble(Console.ReadLine());

        double km = verst * 1066.8 / 1000;

        Console.WriteLine($"{verst} верст(а/ы) - это {km} км.");
    }
}
