using System;
public class Product
{
    private int quantity;
    private double price;

    public Product(int quantity, double price)
    {
        this.quantity = quantity;
        this.price = price;
    }

    public double CalculateProductCost()
    {
        return quantity * price;
    }
}