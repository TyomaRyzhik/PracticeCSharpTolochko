using System;

/// <summary>
/// Делегат для генерации случайного числа.
/// </summary>
public delegate int RandomNumber();

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
        // Создание массива делегатов
        RandomNumber[] delegates = new RandomNumber[5];
        Random rand = new Random();
        for (int i = 0; i < delegates.Length; i++)
        {
            // Присваивание каждому делегату анонимного метода, генерирующего случайное число
            delegates[i] = delegate { return rand.Next(1, 100); };
        }

        // Анонимный метод, который вычисляет среднее значение
        Func<RandomNumber[], double> Average = delegate (RandomNumber[] funcs)
        {
            double sum = 0;
            foreach (var func in funcs)
            {
                sum += func();
            }
            return sum / funcs.Length;
        };

        // Вывод среднего значения
        Console.WriteLine($"Среднее значение: {Average(delegates)}");
        Console.ReadLine();
    }
}
