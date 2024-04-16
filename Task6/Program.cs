using System;
using System.Collections.Generic;

class Program
{
    static double F(double x)
    {
        return Math.Cos(1 / x);
    }

    static List<double> TabulateFunction(double A, double B, int M)
    {
        double H = (B - A) / M;
        double x = A;
        List<double> table = new List<double>();

        for (int i = 0; i <= M; i++)
        {
            table.Add(F(x));
            x += H;
        }

        return table;
    }

    static void Main()
    {

        double A = Math.PI / 4;
        double B = 4 / Math.PI;
        int M = 20;

        List<double> result = TabulateFunction(A, B, M);


        for (int i = 0; i < result.Count; i++)
        {
            double xi = A + i * ((B - A) / M);
            Console.WriteLine("F({0}) = {1}", xi, result[i]);
        }

    }
}