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
        string filePath = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task6\\testfile.txt";

        // Чтение слов из файла и разделение их на массив
        var words = File.ReadAllText(filePath).Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        char startChar = 'a';
        int length = 5;

        // Получение слов, начинающихся на определенную букву
        var wordsStartingWithChar = words.Where(word => word.StartsWith(startChar.ToString()));
        Console.WriteLine($"Слова, начинающиеся на букву '{startChar}': {string.Join(", ", wordsStartingWithChar)}");

        // Получение слов определенной длины
        var wordsWithLength = words.Where(word => word.Length == length);
        Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");

        // Получение слов, начинающихся и заканчивающихся одной буквой
        var wordsStartingAndEndingWithSameChar = words.Where(word => word.First() == word.Last());
        Console.WriteLine($"Слова, начинающиеся и заканчивающиеся одной буквой: {string.Join(", ", wordsStartingAndEndingWithSameChar)}");

        // Если есть слова, получаем слова, начинающиеся на ту же букву, что и последнее слово
        if (words.Any())
        {
            char lastWordStartChar = words.Last().First();
            var wordsStartingWithLastWordStartChar = words.Where(word => word.StartsWith(lastWordStartChar.ToString()));
            Console.WriteLine($"Слова, начинающиеся на ту же букву, что и последнее слово: {string.Join(", ", wordsStartingWithLastWordStartChar)}");
        }
    }
}
