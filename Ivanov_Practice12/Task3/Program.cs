using System;

public delegate void StringOperation(string s);

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров делегатов
        StringOperation Print = (s) => Console.WriteLine(s);
        StringOperation PrintLength = (s) => Console.WriteLine(s.Length);
        StringOperation PrintUpper = (s) => Console.WriteLine(s.ToUpper());

        // Вызов методов через делегат
        Print("Hello");
        PrintLength("Hello");
        PrintUpper("Hello");
        Console.ReadLine();
    }
}
