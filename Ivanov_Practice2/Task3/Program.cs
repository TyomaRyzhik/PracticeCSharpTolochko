using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryNumber bn1 = new BinaryNumber("1010");
        BinaryNumber bn2 = new BinaryNumber("1101");
        BinaryNumber result = bn1.Add(bn2);
        Console.WriteLine($"The sum of {bn1} and {bn2} is {result}");
    }
}
