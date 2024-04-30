using System;

class Program
{
    static void Main(string[] args)
    {
        Quadrilateral[] figures = new Quadrilateral[5];
        figures[0] = new Rectangle { Side1 = 2, Side2 = 3, Name = "Rectangle 1" };
        figures[1] = new Square { Side = 4, Name = "Square 1" };
        figures[2] = new Rectangle { Side1 = 5, Side2 = 6, Name = "Rectangle 2" };
        figures[3] = new Square { Side = 7, Name = "Square 2" };
        figures[4] = new Rectangle { Side1 = 8, Side2 = 9, Name = "Rectangle 3" };

        foreach (var figure in figures)
        {
            Console.WriteLine($"Name: {figure.Name}, Area: {figure.Area()}");
        }
        Console.ReadLine();
    }
}
