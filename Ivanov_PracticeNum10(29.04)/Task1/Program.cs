using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product(10, 100);
        Console.WriteLine("Product cost: " + product.CalculateProductCost());

        Markers markers = new Markers(10, 100, "Marker", 2);
        Console.WriteLine("Markers cost: " + markers.CalculateProductCost());

        Console.ReadLine();
    }
}
