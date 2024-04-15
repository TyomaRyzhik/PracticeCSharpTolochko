using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ширину комнаты A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту комнаты B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ширину окна: ");
        double windowWidth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту окна: ");
        double windowHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ширину двери: ");
        double doorWidth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту двери: ");
        double doorHeight = Convert.ToDouble(Console.ReadLine());

        double windowArea = windowWidth * windowHeight;
        double doorArea = doorWidth * doorHeight;
        double wallArea = 4 * A * B - (windowArea + doorArea);

        Console.WriteLine($"Площадь стен для оклеивания обоями: {wallArea} кв. м.");
    }
}

