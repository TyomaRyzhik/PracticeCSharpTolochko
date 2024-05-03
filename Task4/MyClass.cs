public delegate void MyDelegate();

public class MyClass
{
    public event MyDelegate MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}

public class Observer1
{
    public void HandleEvent()
    {
        Console.WriteLine("Обработчик события в Observer1");
    }
}

public class Observer2
{
    public void HandleEvent()
    {
        Console.WriteLine("Обработчик события в Observer2");
    }
}