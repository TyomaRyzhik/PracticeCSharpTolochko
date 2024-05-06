using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath1 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f1.txt";
        string filePath2 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f2.txt";
        string filePath3 = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task5\\f3.txt";

        int[] numbers1 = { 1, 3, 5, 7, 9 };
        int[] numbers2 = { 2, 4, 6, 8, 10 };
        WriteToFile(filePath1, numbers1);
        WriteToFile(filePath2, numbers2);

        var lines1 = ReadFromFile(filePath1);
        var lines2 = ReadFromFile(filePath2);

        var mergedNumbers = lines1.Concat(lines2).OrderBy(n => n).ToArray();

        WriteToFile(filePath3, mergedNumbers);

        Console.WriteLine("Файл f3.txt успешно создан.");
    }

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
