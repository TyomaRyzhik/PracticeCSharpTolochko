using System;

class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task(1234);
        Task task2 = new Task(5678);
        Task task3 = new Task(9012);

        Console.WriteLine(task1.SwapDigits());
        Console.WriteLine(task2.SwapDigits());
        Console.WriteLine(task3.SwapDigits());
    }
}
