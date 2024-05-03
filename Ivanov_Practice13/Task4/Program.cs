using System;

public class Program
{
    public static void Main()
    {
        MyClass myClass = new MyClass();
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        myClass.MyEvent += observer1.HandleEvent;
        myClass.MyEvent += observer2.HandleEvent;

        myClass.RaiseEvent();

        myClass.MyEvent -= observer1.HandleEvent;

        myClass.RaiseEvent();
    }
}
