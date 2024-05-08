using System;

/// <summary>
/// Делегат для математической операции.
/// </summary>
/// <param name="a">Первый операнд.</param>
/// <param name="b">Второй операнд.</param>
/// <returns>Результат математической операции.</returns>
public delegate double MathOperation(double a, double b);

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
        // Создание экземпляров делегатов
        MathOperation Add = (a, b) => a + b;
        MathOperation Sub = (a, b) => a - b;
        MathOperation Mul = (a, b) => a * b;
        MathOperation Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

        Console.WriteLine("Введите два числа:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: Add, Sub, Mul, Div");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "Add":
                Console.WriteLine($"Результат: {Add(num1, num2)}");
                break;
            case "Sub":
                Console.WriteLine($"Результат: {Sub(num1, num2)}");
                break;
            case "Mul":
                Console.WriteLine($"Результат: {Mul(num1, num2)}");
                break;
            case "Div":
                try
                {
                    Console.WriteLine($"Результат: {Div(num1, num2)}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
        Console.ReadLine();
    }
}
