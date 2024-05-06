using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task3\\file.txt";
        string newFilePath = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task3\\newFile.txt";

        // Создаем текстовый файл и записываем в него 5 строк различной длины
        string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
        File.WriteAllLines(filePath, lines);

        // a) 
        Console.WriteLine("Содержимое файла:");
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }

        // b) 
        int lineCount = File.ReadLines(filePath).Count();
        Console.WriteLine($"Количество строк: {lineCount}");

        // c) 
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }

        // d) 
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Take(lineCount - 1));

        // e)
        int s1 = 1, s2 = 3;
        foreach (var line in File.ReadLines(filePath).Skip(s1 - 1).Take(s2 - s1 + 1))
        {
            Console.WriteLine(line);
        }

        // f) 
        int maxLength = File.ReadLines(filePath).Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");

        // g) 
        string startChar = "В";
        foreach (var line in File.ReadLines(filePath).Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        // h) 
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Reverse());

        Console.ReadLine();
    }
}
