using System;
using System.Linq;

public class Train
{
    public string Number { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }

    public static bool operator >(Train t1, Train t2)
    {
        return t1.DepartureTime > t2.DepartureTime;
    }

    public static bool operator <(Train t1, Train t2)
    {
        return t1.DepartureTime < t2.DepartureTime;
    }
}

public class TrainStation
{
    private Train[] trains;

    public TrainStation(Train[] trains)
    {
        this.trains = trains.OrderBy(t => t.DepartureTime).ToArray();
    }

    public Train this[string number]
    {
        get { return trains.FirstOrDefault(t => t.Number == number); }
    }

    public Train[] GetTrainsDepartingAfter(DateTime time)
    {
        return trains.Where(t => t.DepartureTime > time).ToArray();
    }

    public Train[] GetTrainsToDestination(string destination)
    {
        return trains.Where(t => t.Destination == destination).ToArray();
    }
}