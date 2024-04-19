using System;

static void Main()
{
    byte n = 1; byte i;
    try
    {
        checked //блок с проверкой
        {
            for (i = 1; i < 10; i++) n *= i;
            Console.WriteLine("1: {0}", n);
        }
        unchecked //блок без проверки
        {
            n = 1;
            for (i = 1; i < 10; i++) n *= i;
            Console.WriteLine("2: ", n);
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("возникло переполнение");
    }
}
/* Если поменяем местами блоки unchecked и checked, то вычисление n *= i
 * в блоке checked вызовет исключение OverflowException уже 
 * на первом шаге цикла, так как результат умножения превышает 
 * максимальное значение для типа byte.*/