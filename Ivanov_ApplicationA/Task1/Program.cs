using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        string formattedANumber = $"{a:N2}";
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        string formattedBNumber = $"{b:N2}";
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        string formattedCNumber = $"{c:N2}";
        Console.Write("d = ");
        double d = Convert.ToDouble(Console.ReadLine());
        string formattedDNumber = $"{d:N2}";

        double result = a / b + c / d;
        Console.WriteLine($"{formattedANumber}/{formattedBNumber}+{formattedCNumber}/{formattedDNumber} = {result:N2}");
    }
}