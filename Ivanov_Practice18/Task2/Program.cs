using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        int a = 10, b = 20;
        string path = "C:\\Users\\USER\\Desktop\\36ТП\\3 курс\\Практика Толочко\\Ivanov_Practice18\\Task2\\numbers.txt";

        Queue<int> lessThanA = new Queue<int>();
        Queue<int> betweenAB = new Queue<int>();
        Queue<int> greaterThanB = new Queue<int>();

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int number;
                if (int.TryParse(line, out number))
                {
                    if (number < a)
                    {
                        lessThanA.Enqueue(number);
                    }
                    else if (number > b)
                    {
                        greaterThanB.Enqueue(number);
                    }
                    else
                    {
                        betweenAB.Enqueue(number);
                    }
                }
            }
        }


        PrintQueue(betweenAB);
        PrintQueue(lessThanA);
        PrintQueue(greaterThanB);
    }

    static void PrintQueue(Queue<int> queue)
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
