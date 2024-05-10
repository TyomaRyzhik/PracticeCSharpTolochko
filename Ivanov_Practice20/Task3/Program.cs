using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        TaskExample task1 = new TaskExample(123);
        Task<int> calculation = task1.CalculateSum();

        Task continuation = calculation.ContinueWith(t =>
        {
            Console.WriteLine($"Результат: {t.Result}");
        });

        continuation.Wait();
    }
}
