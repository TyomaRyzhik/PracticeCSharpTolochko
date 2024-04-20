using System;

class Program
{
    static void Main()
    {
        // Создаем и заполняем массив случайными числами
        Random rand = new Random();
        int[,] salaries = new int[20, 12];
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                salaries[i, j] = rand.Next(1000, 5000); // случайная зарплата от 1000 до 5000
            }
        }

        // Вычисляем общую зарплату в феврале и октябре
        int totalSalaryInFebruary = 0;
        int totalSalaryInOctober = 0;
        for (int i = 0; i < 20; i++)
        {
            totalSalaryInFebruary += salaries[i, 1]; // февраль - второй месяц в году, но индекс 1 в массиве
            totalSalaryInOctober += salaries[i, 9]; // октябрь - десятый месяц в году, но индекс 9 в массиве
        }

        // Проверяем условие
        if (totalSalaryInFebruary < totalSalaryInOctober)
        {
            Console.WriteLine("Общая зарплата всех сотрудников в феврале была меньше, чем в октябре.");
        }
        else
        {
            Console.WriteLine("Общая зарплата всех сотрудников в феврале не была меньше, чем в октябре.");
        }
        Console.ReadLine();
    }
}
