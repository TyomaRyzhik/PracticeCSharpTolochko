using System;

class Program
{
    static void Main(string[] args)
    {
        IntArrayVector v1 = new IntArrayVector(0, 4);
        IntArrayVector v2 = new IntArrayVector(0, 4);

        // Заполняем векторы
        for (int i = 0; i < 5; i++)
        {
            v1[i] = i;
            v2[i] = 2 * i;
        }

        // Демонстрация операций
        IntArrayVector sum = v1 + v2;
        IntArrayVector diff = v1 - v2;

        v1.PrintVector();
        v2.PrintVector();
        sum.PrintVector();
        diff.PrintVector();

        // Сравнение векторов
        int comparisonResult = v1.CompareTo(v2);
        Console.WriteLine($"Comparison result: {comparisonResult}");
        Console.ReadLine();
    }
}