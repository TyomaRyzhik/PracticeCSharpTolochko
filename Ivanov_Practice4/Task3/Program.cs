using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение A1: ");
            double A1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение B1: ");
            double B1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение C1: ");
            double C1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение A2: ");
            double A2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение B2: ");
            double B2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение C2: ");
            double C2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Before sorting: A1={A1}, B1={B1}, C1={C1}");
            SortInc3(ref A1, ref B1, ref C1);
            Console.WriteLine($"After sorting: A1={A1}, B1={B1}, C1={C1}");

            Console.WriteLine($"Before sorting: A2={A2}, B2={B2}, C2={C2}");
            SortInc3(ref A2, ref B2, ref C2);
            Console.WriteLine($"After sorting: A2={A2}, B2={B2}, C2={C2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не числовое значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        Console.ReadLine();
    }

    static void SortInc3(ref double A, ref double B, ref double C)
    {
        if (A > B)
        {
            Swap(ref A, ref B);
        }

        if (B > C)
        {
            Swap(ref B, ref C);
        }

        if (A > B)
        {
            Swap(ref A, ref B);
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }
}