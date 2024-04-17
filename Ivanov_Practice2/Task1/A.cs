using System;

public class A
{
    private int a;
    private int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double CalculateExpression()
    {
        return 1.0 / a + 1.0 / Math.Sqrt(b);
    }

    public long CalculatePower()
    {
        return (long)Math.Pow(a, 6);
    }
}
