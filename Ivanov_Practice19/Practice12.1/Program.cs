using System;

/// <summary>
/// Делегат для вычисления свойств фигуры.
/// </summary>
/// <param name="r">Радиус фигуры.</param>
/// <returns>Результат вычисления.</returns>
public delegate double CalcFigure(double r);

/// <summary>
/// Статический класс для геометрических вычислений.
/// </summary>
public static class Geometry
{
    /// <summary>
    /// Вычисляет длину окружности.
    /// </summary>
    /// <param name="r">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    public static double Get_Length(double r)
    {
        return 2 * Math.PI * r;
    }

    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <param name="r">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    public static double Get_Area(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    /// <summary>
    /// Вычисляет объем сферы.
    /// </summary>
    /// <param name="r">Радиус сферы.</param>
    /// <returns>Объем сферы.</returns>
    public static double Get_Volume(double r)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
    }
}

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        double r = 5;
        CalcFigure CF = Geometry.Get_Length;
        Console.WriteLine($"Circle length: {CF(r)}");
        CF = Geometry.Get_Area;
        Console.WriteLine($"Circle area: {CF(r)}");
        CF = Geometry.Get_Volume;
        Console.WriteLine($"Sphere volume: {CF(r)}");
        Console.ReadLine();
    }
}
