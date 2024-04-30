using System;

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine("Value of property C in class A: " + a.C);

        B b1 = new B();
        Console.WriteLine("Value of property C2 in class B with default constructor: " + b1.C2);

        B b2 = new B(3, 7, 2);
        Console.WriteLine("Value of property C2 in class B with parameterized constructor: " + b2.C2);
        
        Console.ReadLine();
    }
}
