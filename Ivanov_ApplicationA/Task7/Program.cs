using System;

class Program
{
   static void Main(string[] args)
   {
        Console.Write("Введите длину стороны a ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину стороны b ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Высоту трапеции h ");
        double h = Convert.ToDouble(Console.ReadLine());

        double s = (a+b)/2 * h;
        Console.WriteLine($"Площадь трапеции = {s}"); ;
   }
}
