using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double start = -1;
        double end = 9;
        double step = 1;

        int steps = (int)((end - start) / step);

        Parallel.For(0, steps, i =>
        {
            double x = start + i * step;
            if (x != 0)
            {
                double result = Math.Cos(1 / x);
                Console.WriteLine($"cos(1/{x}) = {result}");
            }
        });
    }
}
