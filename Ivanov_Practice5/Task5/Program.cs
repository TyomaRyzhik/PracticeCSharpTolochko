using System;

class Program
{
    static double Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        double result = Factorial(n - 1) / Factorial(n);
        Console.WriteLine($"f({n}) = {result}");
        Console.ReadLine();
    }
}
