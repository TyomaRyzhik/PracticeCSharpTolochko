using System;

static void Main()
{
    for (int i = 0; i & lt; 5; i++)
    {
        try
        {
            Console.WriteLine("¬ведите два числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " / " + b + " = " + a / b);
        }

        catch (FormatException)
        {
            Console.WriteLine("Ќужно ввести число!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("ƒелить на нуль нельз€!");
        }
        catch
        {
            Console.WriteLine(" ака€ - то ошибка");
        }
        finally
        {
            Console.WriteLine("после try-блока");
        }
    }
}
/* a=4, b=2: –езультат 2.
 * a=3, b=g: »сключение FormatException. УЌужно ввести число!Ф.
 * a=d, b=1: »сключение FormatException. УЌужно ввести число!Ф.
 * a=2, b=0: »сключени€ DivideByZeroException. Уƒелить на нуль нельз€!Ф.
 * a=123456789987654321, b=1: »сключение OverflowException. У ака€-то ошибкаФ.*/