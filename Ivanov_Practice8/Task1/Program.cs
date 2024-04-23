using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, @"\b[a-zA-Z]+\b");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.ReadLine();
    }
}
