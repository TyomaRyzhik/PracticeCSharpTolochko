using System;

class Program
{
    static void Main()
    {
        const int n = 4;
        NOTE[] notes = new NOTE[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные для записи {i + 1}:");
            Console.Write("Фамилия: ");
            notes[i].LastName = Console.ReadLine();
            Console.Write("Имя: ");
            notes[i].FirstName = Console.ReadLine();
            Console.Write("Номер телефона: ");
            notes[i].PhoneNumber = Console.ReadLine();
            Console.Write("День рождения: ");
            notes[i].BirthDate = new int[3];
            notes[i].BirthDate[0] = int.Parse(Console.ReadLine());
            Console.Write("Месяц рождения: ");
            notes[i].BirthDate[1] = int.Parse(Console.ReadLine());
            Console.Write("Год рождения: ");
            notes[i].BirthDate[2] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введите номер месяца (1-12): ");
        int inputMonth = int.Parse(Console.ReadLine());

        bool found = false;
        foreach (var note in notes)
        {
            if (note.BirthDate[1] == inputMonth)
            {
                found = true;
                Console.WriteLine($"Имя: {note.FirstName} {note.LastName}, Телефон: {note.PhoneNumber}");
            }
        }

        if (!found)
            Console.WriteLine("В указанном месяце нет дней рождения.");

        Console.ReadLine();
    }
}
