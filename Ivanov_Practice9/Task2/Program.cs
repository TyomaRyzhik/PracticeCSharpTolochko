using System;

class Program
{
    static void Main()
    {
        var accountant = new Accountant();
        var workerName = "John";
        var workedHours = 180;
        var bonusEligible = accountant.AskForBonus(workerName, workedHours);
        if (bonusEligible)
        {
            Console.WriteLine($"{workerName} заслуживает премию!");
        }
        else
        {
            Console.WriteLine($"{workerName} не получает премию.");
        }
        Console.ReadLine();
    }
}
