using System;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        int[] array = myList.GetArray();

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
