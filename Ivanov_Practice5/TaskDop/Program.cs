using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 7;
        int[,] spiralMatrix = new int[size, size];

        int value = 1;
        int minCol = 0;
        int maxCol = size - 1;
        int minRow = 0;
        int maxRow = size - 1;

        while (value <= size * size)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                spiralMatrix[minRow, i] = value;
                value++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                spiralMatrix[i, maxCol] = value;
                value++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                spiralMatrix[maxRow, i] = value;
                value++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                spiralMatrix[i, minCol] = value;
                value++;
            }
            minCol++;
        }

        // Выводим матрицу
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(spiralMatrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();

    }
}
