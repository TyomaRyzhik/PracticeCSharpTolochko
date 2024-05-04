using System;
using System.Threading;

class Program
{
    static AutoResetEvent autoEvent1 = new AutoResetEvent(false);
    static AutoResetEvent autoEvent2 = new AutoResetEvent(false);

    static void Main()
    {
        Thread t1 = new Thread(() => PrintNumbers(0, 1));
        t1.Priority = ThreadPriority.Lowest; // Можно изменить приоритет
        t1.Start();

        Thread t2 = new Thread(() => PrintNumbers(10, 2));
        t2.Priority = ThreadPriority.BelowNormal; // Можно изменить приоритет
        t2.Start();

        Thread t3 = new Thread(() => PrintNumbers(20, 3));
        t3.Priority = ThreadPriority.Normal; // Можно изменить приоритет
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.ReadLine();
    }

    static void PrintNumbers(int start, int threadNumber)
    {
        for (int i = start; i < start + 10; i++)
        {
            if (threadNumber == 1)
            {
                Console.WriteLine(i);
                autoEvent1.Set();
            }
            else if (threadNumber == 2)
            {
                autoEvent1.WaitOne();
                Console.WriteLine(i);
                autoEvent2.Set();
            }
            else if (threadNumber == 3)
            {
                autoEvent2.WaitOne();
                Console.WriteLine(i);
            }

            Thread.Sleep(1000); // Использование Sleep
        }
    }
}
