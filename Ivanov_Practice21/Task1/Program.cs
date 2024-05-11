using System;

internal class Program
{
    static void Main(string[] args)
    {
        ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

        boiler.Fill(); 
        boiler.Boil(); 

        bool isEmpty = boiler.IsEmpty();
        Console.WriteLine("Бойлер пуст: " + isEmpty);

        boiler.Drain();

        isEmpty = boiler.IsEmpty();
        Console.WriteLine("Бойлер пуст: " + isEmpty);

        Console.ReadLine();
    }
}
