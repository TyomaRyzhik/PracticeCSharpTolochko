using System;

static void Main()
{
    for (int i = 0; i & lt; 5; i++)
    {
        try
        {
            Console.WriteLine("������� ��� �����");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " / " + b + " = " + a / b);
        }

        catch (FormatException)
        {
            Console.WriteLine("����� ������ �����!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("������ �� ���� ������!");
        }
        catch
        {
            Console.WriteLine("����� - �� ������");
        }
        finally
        {
            Console.WriteLine("����� try-�����");
        }
    }
}
/* a=4, b=2: ��������� 2.
 * a=3, b=g: ���������� FormatException. ������ ������ �����!�.
 * a=d, b=1: ���������� FormatException. ������ ������ �����!�.
 * a=2, b=0: ���������� DivideByZeroException. ������� �� ���� ������!�.
 * a=123456789987654321, b=1: ���������� OverflowException. ������-�� �������.*/