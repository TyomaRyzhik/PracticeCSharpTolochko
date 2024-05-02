using System;

public delegate int RandomNumber();

class Program
{
    static void Main(string[] args)
    {
        RandomNumber[] delegates = new RandomNumber[5];
        Random rand = new Random();
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate { return rand.Next(1, 100); };
        }

        // Анонимный метод, который вычисляет среднее значение
        Func<RandomNumber[], double> Average = delegate (RandomNumber[] funcs)
        {
            double sum = 0;
            foreach (var func in funcs)
            {
                sum += func();
            }
            return sum / funcs.Length;
        };

        Console.WriteLine($"Среднее значение: {Average(delegates)}");
        Console.ReadLine();
    }
}
