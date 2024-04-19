using System;

class Program
{
    static void Main()
    {
        byte x = 200; byte y = 200;
        try
        {
            byte result = (byte)(x + y);
            Console.WriteLine(" 1: { 0} ", result);
            result = checked((byte)(x + y));
            Console.WriteLine(" 2: ", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}
/* После того, как мы уберем блок unchecked, все выражения 
 * в программе будут проверяться на переполнение. Это означает, 
 * что выражение (byte)(x + y) останется таким же, но оно должно измениться*/
