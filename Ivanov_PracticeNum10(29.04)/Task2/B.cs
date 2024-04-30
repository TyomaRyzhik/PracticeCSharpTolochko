public class B : A
{
    private int d = 15;

    public B() : base()
    {
    }

    public B(int a, int b, int d)
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }

    public int C2
    {
        get
        {
            switch (d)
            {
                case 1:
                    return a + b + d;
                case 2:
                    return a - b + d;
                default:
                    return a * b + d;
            }
        }
    }
}