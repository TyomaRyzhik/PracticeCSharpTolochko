using System;
using System.Linq;

/// <summary>
/// Класс для работы с двумерными массивами.
/// </summary>
public class Array2D
{
    private int[,] array;

    /// <summary>
    /// Конструктор класса Array2D.
    /// </summary>
    /// <param name="array">Двумерный массив.</param>
    public Array2D(int[,] array)
    {
        this.array = array;
    }

    /// <summary>
    /// Метод для умножения положительных элементов массива, меньших 10.
    /// </summary>
    /// <returns>Произведение положительных элементов массива, меньших 10.</returns>
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

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Array2D array2D = new Array2D(array);
        int product = array2D.MultiplyPositiveElementsLessThan10();
        Console.WriteLine("Произведение положительных элементов массива, меньших 10: " + product);
        Console.ReadLine();
    }
}
