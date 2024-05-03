using System;

public class Program
{
    public static void Main()
    {
        MyInfo myInfo = new MyInfo();
        myInfo.NameChanged += (oldName, newName) => Console.WriteLine($"Имя изменено с {oldName} на {newName}");
        myInfo.Name = "Артём";
        Console.ReadLine();
    }
}