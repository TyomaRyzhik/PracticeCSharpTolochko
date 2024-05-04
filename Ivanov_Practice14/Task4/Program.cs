using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Последовательность натуральных чисел
        int[] numbers = Enumerable.Range(0, 100).ToArray();

        // Количество потоков
        int threadCount = Environment.ProcessorCount;

        // Создаем задачи
        Task<int>[] tasks = new Task<int>[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            // Номер процесса или номер части массива, обрабатываемой потоком
            int start = i * (numbers.Length / threadCount);
            int end = (i == threadCount - 1) ? numbers.Length : start + (numbers.Length / threadCount);

            tasks[i] = Task.Factory.StartNew(() => SumEvenNumbers(numbers, start, end));
        }

        // Ожидаем завершения всех потоков
        Task.WaitAll(tasks);

        // Находим общую сумму
        int totalSum = tasks.Sum(t => t.Result);

        Console.WriteLine($"Сумма четных чисел: {totalSum}");

        Console.ReadLine();
    }

    // Функция потока, возвращающая частичную сумму
    static int SumEvenNumbers(int[] numbers, int start, int end)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
        }
        return sum;
    }
}
