using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        string filePath1 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task4\\file1.txt";
        string filePath2 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task4\\file2.txt";

        var lines1 = File.ReadLines(filePath1).ToList();
        var lines2 = File.ReadLines(filePath2).ToList();

        if (lines1.Count != lines2.Count)
        {
            Console.WriteLine("Файлы имеют разное количество строк.");
            return;
        }

        for (int i = 0; i < lines1.Count; i++)
        {
            if (lines1[i] != lines2[i])
            {
                Console.WriteLine($"Файлы отличаются на строке {i + 1}.");
                return;
            }
        }

        Console.WriteLine("Строки всех файлов совпадают.");
    }
}
