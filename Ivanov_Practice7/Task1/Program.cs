using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сообщение:");
        string message = Console.ReadLine();

        string[] words = message.Split(' ');
        Regex regex = new Regex(@"\d");

        Console.WriteLine("Слова, содержащие хотя бы одну цифру:");
        foreach (string word in words)
        {
            if (regex.IsMatch(word))
            {
                Console.WriteLine(word);
            }
        }
        Console.ReadLine();
    }
}