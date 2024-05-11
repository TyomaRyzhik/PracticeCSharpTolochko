using System;

public class ChocolateBoiler
{
    private bool empty;
    private bool boiled;
    private static ChocolateBoiler uniqueInstance;

    private ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new ChocolateBoiler();
        }
        return uniqueInstance;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            empty = false;
            boiled = false;
            // Заполнение бойлера молочно-шоколадной смесью
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            // Слив готового молока и шоколада
            empty = true;
        }
    }


    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            // Вскипятить содержимое бойлера
            boiled = true;
        }
    }

    public bool IsEmpty()
    {
        return empty;
    }

    public bool IsBoiled()
    {
        return boiled;
    }
}
