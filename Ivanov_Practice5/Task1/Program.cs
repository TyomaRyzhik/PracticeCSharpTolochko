using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { -1, 2, -3, 4, -5, 6, -7, 8, -9 };

        for (int i = 0; i < array.Length; i++)
        {
            if (0 < array[i] && array[i] < 3.2)
            {
                Console.WriteLine($"Номер элемента: {i}");
            }
        }
        Console.ReadLine();
    }
}
