using System;

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(2, 4);
        Console.WriteLine("Результат вычисления выражения: " + obj.CalculateExpression());
        Console.WriteLine("Результат вычисления a^6: " + obj.CalculatePower());
    }
}