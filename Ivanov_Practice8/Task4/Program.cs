﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текст: ")
        string input = Console.ReadLine(); ;
        MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]*\b");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

    }
}