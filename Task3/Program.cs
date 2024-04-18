using System;

class Program
{
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
