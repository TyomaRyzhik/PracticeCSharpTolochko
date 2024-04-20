using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Создаем и заполняем массив случайными числами
        Random rand = new Random();
        int[] a = new int[20];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rand.Next(-10, 10) * 10; // случайное число от 0 до 10
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }

        // Преобразуем массив
        for (int i = 0; i < 10; i++)
        {
            if (a[i] > a[i + 10])
            {
                int temp = a[i];
                a[i] = a[i + 10];
                a[i + 10] = temp;
            }
        }

        // Сортируем массив
        Array.Sort(a);

        // Выводим отсортированный массив
        Console.WriteLine("\nОтсортированный массив:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }

        // Запрашиваем число для бинарного поиска
        Console.WriteLine("\nВведите число для бинарного поиска:");
        int k = int.Parse(Console.ReadLine());

        // Выполняем бинарный поиск
        int index = Array.BinarySearch(a, k);
        if (index < 0)
        {
            Console.WriteLine($"Число {k} не найдено в массиве.");
        }
        else
        {
            Console.WriteLine($"Число {k} найдено в массиве на позиции {index}.");
        }
        Console.ReadLine();
    }
}
