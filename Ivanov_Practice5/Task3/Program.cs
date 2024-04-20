using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (N < 10): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите нижнюю границу диапазона a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите верхнюю границу диапазона b: ");
        int b = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int[,] matrix = new int[N, N];
        int sum = 0;

        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < N; i++)
        {
            int min = b;
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");

                if (matrix[i, j] < 0)
                {
                    sum += matrix[i, j] * matrix[i, j];
                }

                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            Console.WriteLine($"Наименьший элемент в строке: {min}");
        }

        Console.WriteLine($"\nСумма квадратов отрицательных чисел: {sum}");
        Console.ReadLine();
    }
}
