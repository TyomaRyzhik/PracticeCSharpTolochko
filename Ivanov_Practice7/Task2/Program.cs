using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Console.WriteLine("Слова, которые начинаются и заканчиваются одной и той же буквой:");
        foreach (string word in words)
        {
            if (word[0] == word[word.Length - 1])
            {
                Console.WriteLine(word);
            }
        }
        Console.ReadLine();
    }
}
