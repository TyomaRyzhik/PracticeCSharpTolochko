using System;

class Program
{
    static void Main(string[] args)
    {
        Foundation[] foundations = new Foundation[5];
        foundations[0] = new FoundationType1 { Height = 2 };
        foundations[1] = new FoundationType2 { Height = 4 };
        foundations[2] = new FoundationType1 { Height = 5 };
        foundations[3] = new FoundationType2 { Height = 7 };
        foundations[4] = new FoundationType1 { Height = 8 };

        double maxHeight = double.MinValue;
        foreach (var foundation in foundations)
        {
            foundation.Display();
            if (foundation.Height > maxHeight)
            {
                maxHeight = foundation.Height;
            }
        }

        Console.WriteLine($"The maximum foundation height is: {maxHeight}");
        Console.ReadLine();
    }
}
