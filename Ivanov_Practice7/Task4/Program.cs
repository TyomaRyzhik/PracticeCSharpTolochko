using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string secondName = "Пушкин";
        string firstName = "Александр";
        string lastName = "Сергеевич";
        string fullName = firstName + lastName + secondName;

        fullName = fullName.ToUpper();

        int kod = СalculateСode(fullName);

        Console.WriteLine("ФИО: " + firstName + " " + lastName + " " + secondName);
        Console.WriteLine("Код личности: " + kod);
        Console.ReadKey();
        Console.ReadLine();
    }

    static int СalculateСode(string name)
    {
        int sum = 0;

        char[] alphabet = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        char[] fulllname = name.ToCharArray();
        foreach (char symbol in fulllname)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (symbol == alphabet[i])
                {
                    sum += i + 1;
                }
            }
        }

        string numbers;

        while (sum >= 10)
        {
            numbers = sum.ToString();
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i].ToString();
                int numb = int.Parse(number);
                sum += numb;
            }
        }

        return sum;
    }
}