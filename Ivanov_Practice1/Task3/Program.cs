using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ввидете число от 1 до 4");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Ввидете число от 6 до 14");
        int k = int.Parse(Console.ReadLine());

        if (k >= 6 && k <= 14)
        {
            switch (k)
            {
                
                case 11:
                Console.WriteLine("Валет");
                break;

                case 12:
                Console.WriteLine("Дамма");
                break;

                case 13:
                Console.WriteLine("Король");
                break;

                case 14:
                Console.WriteLine("Туз");
                break;

                default:
                Console.WriteLine(k);
                break;
            }
        }
        else
        {
            Console.WriteLine("????");
        }

        if (m <= 4 && m >= 1)
        {
            switch (m)
            {
                case 1:
                    Console.WriteLine("Чирв");
                    break;

                case 2:
                    Console.WriteLine("Бубен");
                    break;

                case 3:
                    Console.WriteLine("Пик");
                    break;

                case 4:
                    Console.WriteLine("Крести");
                    break;
            }
        }
    }
}
