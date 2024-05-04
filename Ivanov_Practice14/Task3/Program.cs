using System;
using System.Threading;

class Program
{
    static object lockObject = new object();

    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Thread t1 = new Thread(() => SumNumbers(A, N));
        t1.Start();

        Thread t2 = new Thread(() => SumNumbers(A, N));
        t2.Start();

        Thread t3 = new Thread(() => MultiplyNumbers(A, N));
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.ReadLine();
    }

    static void SumNumbers(int A, int N)
    {
        int sum = A;
        for (int i = 1; i <= N; i++)
        {
            sum += A;
        }
        Console.WriteLine($"Сумма чисел: {sum}");
    }

    static void MultiplyNumbers(int A, int N)
    {
        lock (lockObject)
        {
            int product = A;
            for (int i = 1; i <= N; i++)
            {
                product *= A;
            }
            Console.WriteLine($"Произведение чисел: {product}");
        }
    }
}
