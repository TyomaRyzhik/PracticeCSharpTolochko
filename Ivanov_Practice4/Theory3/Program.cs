static void genException()
{
    Console.WriteLine("a=");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("b=");
    double b = double.Parse(Console.ReadLine());
    int f = 1;
    try //Внешний блок-try
    {
        for (double i = a; i <= b; ++i)
        {
            try //Внутренний блок-try
            {
                f = checked((int)(f * i));
                if (Math.Abs(f - 1) < 0.000001)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("y({0})=Деление на 0", i);
            }
        }
    }
    catch (ArithmeticException)
    {
        Console.WriteLine("ERROR");
        throw; //повторная генерация исключения
    }
}

static void Main()
{
    try
    {
        genException();
    }
    catch
    {
        Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
    }
}
/* 1. Исключение не было сгенерировано, потому что значение 
 * f - 1 никогда не становится равным нулю. В коде f 
 * увеличивается на каждом шаге цикла, поэтому f - 1 всегда 
 * будет больше нуля.
 * 2. Нужно добавить проверку перед вычислением 100 / (f - 1). */