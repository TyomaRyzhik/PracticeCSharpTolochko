using System;
using System.Linq;

public class BinaryNumber
{
    private string binaryString;

    public BinaryNumber(string binaryString)
    {
        if (binaryString.All(c => c == '0' || c == '1'))
        {
            this.binaryString = binaryString;
        }
        else
        {
            throw new ArgumentException("The input string is not a valid binary number.");
        }
    }

    public int ToInt()
    {
        return Convert.ToInt32(binaryString, 2);
    }

    public BinaryNumber Add(BinaryNumber other)
    {
        int thisInt = this.ToInt();
        int otherInt = other.ToInt();
        int resultInt = thisInt + otherInt;
        string resultBinaryString = Convert.ToString(resultInt, 2);
        return new BinaryNumber(resultBinaryString);
    }

    public override string ToString()
    {
        return binaryString;
    }
}
