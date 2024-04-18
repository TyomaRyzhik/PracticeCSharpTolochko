using System;
using System.Linq;

public class Array2D
{
    private int[,] array;

    public Array2D(int[,] array)
    {
        this.array = array;
    }

    public int MultiplyPositiveElementsLessThan10()
    {
        int product = 1;
        foreach (int element in array)
        {
            if (element > 0 && element < 10)
            {
                product *= element;
            }
        }
        return product;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Array2D array2D = new Array2D(array);
        int product = array2D.MultiplyPositiveElementsLessThan10();
        Console.WriteLine("Произведение положительных элементов массива, меньших 10: " + product);
        Console.ReadLine();
    }
}
