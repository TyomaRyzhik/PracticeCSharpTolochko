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
        // Получение списка логических дисков
        string[] drives = Directory.GetLogicalDrives();
        foreach (string drive in drives)
        {
            Console.WriteLine($"Drive: {drive}");
            try
            {
                // Получение списка файлов на диске
                var files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Обработка исключения, если нет доступа к диску
                Console.WriteLine("Нет доступа к этому диску.");
            }
        }

        // Создание новой папки
        string directoryPath = @"C:\\Users\\USER\\Desktop\\36ТП\\Example_36tp";
        Directory.CreateDirectory(directoryPath);

        // Копирование файлов из одной папки в другую
        string sourceDirectory = @"C:\\Users\\USER\\Desktop\\36ТП\\Состав 36тп";
        var sourceFiles = Directory.GetFiles(sourceDirectory).Take(3);
        foreach (var sourceFile in sourceFiles)
        {
            string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, destinationFile);
        }

        // Установка атрибута "скрытый" для скопированных файлов
        var copiedFiles = Directory.GetFiles(directoryPath);
        foreach (var copiedFile in copiedFiles)
        {
            File.SetAttributes(copiedFile, FileAttributes.Hidden);
        }
    }
}
