using System;
using System.Threading;
using System.Threading.Tasks;

public class TaskExample
{
    public static void Main()
    {
        Task[] tasks = new Task[2];

        tasks[0] = Task.Run(() =>
        {
            Thread.Sleep(2000); // Задержка 2 секунды
            Console.WriteLine("Задача 1 выполнена");
            // Здесь может быть код для вычисления значения функции
        });

        tasks[1] = Task.Run(() =>
        {
            Thread.Sleep(1000); // Задержка 1 секунда
            Console.WriteLine("Задача 2 выполнена");
            // Здесь может быть код для вычисления значения функции
        });

        // 1. Дождитесь выполнения всех задач
        Task.WaitAll(tasks);
        Console.WriteLine("Все задачи выполнены");

        // 2. Дождитесь выполнения хотя бы одной задачи
        int index = Task.WaitAny(tasks);
        Console.WriteLine($"Задача {index + 1} выполнена первой");
    }
}
