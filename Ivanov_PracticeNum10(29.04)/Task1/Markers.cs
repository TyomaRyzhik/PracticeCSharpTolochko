using System;

public class Markers : Product
{
    private string name;
    private double grade;

    public Markers(int quantity, double price, string name, double grade) : base(quantity, price)
    {
        this.name = name;
        this.grade = grade;
    }

    public new double CalculateProductCost()
    {
        return base.CalculateProductCost() / Math.Sqrt(grade);
    }
}