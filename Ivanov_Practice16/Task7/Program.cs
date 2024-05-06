using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] drives = Directory.GetLogicalDrives();
        foreach (string drive in drives)
        {
            Console.WriteLine($"Drive: {drive}");
            try
            {
                var files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к этому диску.");
            }
        }

        string directoryPath = @"C:\\Users\\USER\\Desktop\\36ТП\\Example_36tp";
        Directory.CreateDirectory(directoryPath);

        string sourceDirectory = @"C:\\Users\\USER\\Desktop\\36ТП\\Состав 36тп";
        var sourceFiles = Directory.GetFiles(sourceDirectory).Take(3);
        foreach (var sourceFile in sourceFiles)
        {
            string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, destinationFile);
        }

        var copiedFiles = Directory.GetFiles(directoryPath);
        foreach (var copiedFile in copiedFiles)
        {
            File.SetAttributes(copiedFile, FileAttributes.Hidden);
        }
    }
}
