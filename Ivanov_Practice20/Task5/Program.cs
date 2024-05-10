using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 34, 7, 87, 12 };
        CancellationTokenSource cts = new CancellationTokenSource();

        try
        {
            Parallel.ForEach(numbers, new ParallelOptions { CancellationToken = cts.Token }, number =>
            {
                int sum = Enumerable.Range(0, number + 1).Sum();
                int product = Enumerable.Range(1, number + 1).Aggregate(1, (a, b) => a * b);

                Console.WriteLine($"Number: {number}, Sum: {sum}, Product: {product}");

                if (sum > 535 || product > 535)
                {
                    cts.Cancel();
                }
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Вычисление прервано");
        }
    }
}
