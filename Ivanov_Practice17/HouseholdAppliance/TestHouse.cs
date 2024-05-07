using System;
using static HouseholdAppliance;

class Program
{
    static void Main(string[] args)
    {
        // Создаем новый объект класса Refrigerator
        Refrigerator myFridge = new Refrigerator("Samsung", "RT29K5030S8", 500.0, 4.0);

        // Включаем холодильник
        myFridge.SwitchOn();

        // Устанавливаем температуру
        myFridge.SetTemperature(3.0);

        // Выводим информацию о холодильнике
        Console.WriteLine($"Brand: {myFridge.Brand}");
        Console.WriteLine($"Model: {myFridge.Model}");
        Console.WriteLine($"Price: {myFridge.Price}");
        Console.WriteLine($"Temperature: {myFridge.Temperature}");

        // Выключаем холодильник
        myFridge.SwitchOff();
    }
}
