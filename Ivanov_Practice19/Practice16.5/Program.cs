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
        string filePath1 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f1.txt";
        string filePath2 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f2.txt";
        string filePath3 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f3.txt";

        int[] numbers1 = { 1, 3, 5, 7, 9 };
        int[] numbers2 = { 2, 4, 6, 8, 10 };

        // Запись чисел в файлы
        WriteToFile(filePath1, numbers1);
        WriteToFile(filePath2, numbers2);

        // Чтение чисел из файлов
        var lines1 = ReadFromFile(filePath1);
        var lines2 = ReadFromFile(filePath2);

        // Объединение и сортировка чисел
        var mergedNumbers = lines1.Concat(lines2).OrderBy(n => n).ToArray();

        // Запись отсортированных чисел в новый файл
        WriteToFile(filePath3, mergedNumbers);

        Console.WriteLine("Файл f3.txt успешно создан.");
    }

    /// <summary>
    /// Метод для записи массива чисел в файл.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <param name="numbers">Массив чисел для записи.</param>
    static void WriteToFile(string filePath, int[] numbers)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            foreach (var number in numbers)
            {
                writer.Write(number);
            }
        }
    }

    /// <summary>
    /// Метод для чтения чисел из файла.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <returns>Массив прочитанных чисел.</returns>
    static int[] ReadFromFile(string filePath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            var numbers = new System.Collections.Generic.List<int>();
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                numbers.Add(reader.ReadInt32());
            }
            return numbers.ToArray();
        }
    }
}
