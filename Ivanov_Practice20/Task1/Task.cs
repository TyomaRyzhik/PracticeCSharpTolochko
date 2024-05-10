using System;
public class Task
{
    private int number;

    public Task(int number)
    {
        this.number = number;
    }

    public int SwapDigits()
    {
        if (1000 <= this.number && this.number <= 9999)
        {
            char[] digits = this.number.ToString().ToCharArray();
            char temp = digits[1];
            digits[1] = digits[2];
            digits[2] = temp;
            return int.Parse(new string(digits));
        }
        else
        {
            throw new ArgumentException("Число должно быть четырехзначным.");
        }
    }
}