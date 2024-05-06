using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice16\\Task6\\testfile.txt";

        // Считываем все слова из файла
        var words = File.ReadAllText(filePath).Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Задаем букву и длину для поиска слов
        char startChar = 'a'; // Замените на нужную букву
        int length = 5; // Замените на нужную длину

        // Выводим все слова, которые начинаются на заданную букву
        var wordsStartingWithChar = words.Where(word => word.StartsWith(startChar.ToString()));
        Console.WriteLine($"Слова, начинающиеся на букву '{startChar}': {string.Join(", ", wordsStartingWithChar)}");

        // Выводим все слова, длина которых равна заданному числу
        var wordsWithLength = words.Where(word => word.Length == length);
        Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");

        // Выводим все слова, которые начинаются и заканчиваются одной буквой
        var wordsStartingAndEndingWithSameChar = words.Where(word => word.First() == word.Last());
        Console.WriteLine($"Слова, начинающиеся и заканчивающиеся одной буквой: {string.Join(", ", wordsStartingAndEndingWithSameChar)}");

        // Выводим все слова, которые начинаются на ту же букву, что и последнее слово
        if (words.Any())
        {
            char lastWordStartChar = words.Last().First();
            var wordsStartingWithLastWordStartChar = words.Where(word => word.StartsWith(lastWordStartChar.ToString()));
            Console.WriteLine($"Слова, начинающиеся на ту же букву, что и последнее слово: {string.Join(", ", wordsStartingWithLastWordStartChar)}");
        }
    }
}
