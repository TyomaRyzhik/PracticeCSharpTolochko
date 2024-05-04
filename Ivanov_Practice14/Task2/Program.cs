using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Thread t1 = new Thread(SumNumbers);
        t1.Start();

        Thread t2 = new Thread(SumNumbers);
        t2.Start();

        t1.Join();
        t2.Join();

        stopwatch.Stop();
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        Console.ReadLine();
    }

    static void SumNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
    }
}
