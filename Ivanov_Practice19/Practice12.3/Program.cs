using System;

/// <summary>
/// Делегат для операции со строкой.
/// </summary>
/// <param name="s">Строка для выполнения операции.</param>
public delegate void StringOperation(string s);

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        // Создание экземпляров делегатов
        StringOperation Print = (s) => Console.WriteLine(s);
        StringOperation PrintLength = (s) => Console.WriteLine(s.Length);
        StringOperation PrintUpper = (s) => Console.WriteLine(s.ToUpper());

        Print("Hello");
        PrintLength("Hello");
        PrintUpper("Hello");
        Console.ReadLine();
    }
}
