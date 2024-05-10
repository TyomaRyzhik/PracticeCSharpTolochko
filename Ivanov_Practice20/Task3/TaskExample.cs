using System;

public class TaskExample
{
    private int number;

    public TaskExample(int number)
    {
        this.number = number;
    }

    public Task<int> CalculateSum()
    {
        return Task.Run(() =>
        {
            if (100 <= this.number && this.number <= 999)
            {
                int firstDigit = this.number / 100;
                int secondDigit = (this.number / 10) % 10;
                return firstDigit + secondDigit;
            }
            else
            {
                throw new ArgumentException("Число должно быть трехзначным.");
            }
        });
    }
}