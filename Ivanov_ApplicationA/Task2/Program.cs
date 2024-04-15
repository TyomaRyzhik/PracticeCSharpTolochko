using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 1000;      
        int secondDigit = (number / 100) % 10; 
        int thirdDigit = (number / 10) % 10;  
        int fourthDigit = number % 10;        

        int newNumber = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;

        Console.WriteLine("Перестановка цифр: " + newNumber);
    }
}

