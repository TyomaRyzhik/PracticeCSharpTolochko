using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, @"\b\d{2}/\d{2}/\d{4}\b");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.ReadLine();
    }
}
