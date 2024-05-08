using System;
using System.IO;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Имя новой папки
        string folderName = "New_folder_36TP";

        // Создание новой папки
        Directory.CreateDirectory(folderName);

        // Получение полного пути к папке
        string fullPath = Path.GetFullPath(folderName);

        // Вывод полного пути к папке
        Console.WriteLine($"Полный путь к папке: {fullPath}");

        Console.ReadLine();
    }
}
