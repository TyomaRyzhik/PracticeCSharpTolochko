using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ввидите а => ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ввидите b => ");
        int b = int.Parse(Console.ReadLine());
        int answer = 0;

        for (int i = a; i <= b; i++)
        {
            answer *= i;
        }

        Console.WriteLine(answer);
    }
}
