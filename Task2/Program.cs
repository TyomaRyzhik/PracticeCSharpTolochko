using System;

class Program
{
    static void Main()
    {
        double A1 = 5, B1 = 3, C1 = 7;
        double A2 = 2, B2 = 8, C2 = 1;

        Console.WriteLine($"Before sorting: A1={A1}, B1={B1}, C1={C1}");
        SortDec3(ref A1, ref B1, ref C1);
        Console.WriteLine($"After sorting: A1={A1}, B1={B1}, C1={C1}");

        Console.WriteLine($"Before sorting: A2={A2}, B2={B2}, C2={C2}");
        SortDec3(ref A2, ref B2, ref C2);
        Console.WriteLine($"After sorting: A2={A2}, B2={B2}, C2={C2}");
        Console.Read();
    }

    static void SortDec3(ref double A, ref double B, ref double C)
    {
        if (A < B)
        {
            Swap(ref A, ref B);
        }

        if (A < C)
        {
            Swap(ref A, ref C);
        }

        if (B < C)
        {
            Swap(ref B, ref C);
        }
    }

    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }
}
