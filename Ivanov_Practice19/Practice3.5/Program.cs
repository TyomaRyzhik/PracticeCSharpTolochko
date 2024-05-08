using System;
using System.Linq;

/// <summary>
/// Класс, представляющий поезд.
/// </summary>
public class Train
{
    /// <summary>
    /// Номер поезда.
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Пункт назначения поезда.
    /// </summary>
    public string Destination { get; set; }

    /// <summary>
    /// Время отправления поезда.
    /// </summary>
    public DateTime DepartureTime { get; set; }

    /// <summary>
    /// Оператор больше для сравнения времени отправления двух поездов.
    /// </summary>
    public static bool operator >(Train t1, Train t2)
    {
        return t1.DepartureTime > t2.DepartureTime;
    }

    /// <summary>
    /// Оператор меньше для сравнения времени отправления двух поездов.
    /// </summary>
    public static bool operator <(Train t1, Train t2)
    {
        return t1.DepartureTime < t2.DepartureTime;
    }
}

/// <summary>
/// Класс, представляющий железнодорожную станцию.
/// </summary>
public class TrainStation
{
    private Train[] trains;

    /// <summary>
    /// Конструктор класса TrainStation.
    /// </summary>
    public TrainStation(Train[] trains)
    {
        this.trains = trains.OrderBy(t => t.DepartureTime).ToArray();
    }

    /// <summary>
    /// Индексатор для получения поезда по номеру.
    /// </summary>
    public Train this[string number]
    {
        get { return trains.FirstOrDefault(t => t.Number == number); }
    }

    /// <summary>
    /// Метод для получения поездов, отправляющихся после указанного времени.
    /// </summary>
    public Train[] GetTrainsDepartingAfter(DateTime time)
    {
        return trains.Where(t => t.DepartureTime > time).ToArray();
    }

    /// <summary>
    /// Метод для получения поездов, следующих до указанного пункта назначения.
    /// </summary>
    public Train[] GetTrainsToDestination(string destination)
    {
        return trains.Where(t => t.Destination == destination).ToArray();
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
        Train[] trains = new Train[]
        {
            new Train { Number = "1", Destination = "City1", DepartureTime = DateTime.Now.AddHours(1) },
            new Train { Number = "2", Destination = "City2", DepartureTime = DateTime.Now.AddHours(2) },
            new Train { Number = "3", Destination = "City1", DepartureTime = DateTime.Now.AddHours(3) },
        };

        TrainStation station = new TrainStation(trains);

        Console.WriteLine("Train 1: " + station["1"].Destination);
        Console.WriteLine("Trains departing after now: " + station.GetTrainsDepartingAfter(DateTime.Now).Length);
        Console.WriteLine("Train 1 > Train 2: " + (station["1"] > station["2"]));
        Console.WriteLine("Trains to City1: " + station.GetTrainsToDestination("City1").Length);
        Console.Read();
    }
}
