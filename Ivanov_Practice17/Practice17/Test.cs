using System;
using static Shape;

class Program
{
    static void Main(string[] args)
    {
        // Создаем новый объект класса Triangle
        Triangle myTriangle = new Triangle(3.0, 4.0, 5.0);

        // Выводим информацию о треугольнике
        Console.WriteLine($"Triangle Type: {myTriangle.Type()}");
        Console.WriteLine($"Triangle Area: {myTriangle.Area()}");
        Console.WriteLine($"Triangle Perimeter: {myTriangle.Perimeter()}");

        // Создаем новый объект класса Rectangle
        Rectangle myRectangle = new Rectangle(5.0, 6.0);

        // Выводим информацию о прямоугольнике
        Console.WriteLine($"Rectangle Area: {myRectangle.Area()}");
        Console.WriteLine($"Rectangle Perimeter: {myRectangle.Perimeter()}");
    }
}
