using System;

public class MyList<T>
{
    private T[] array;
    private int count = 0;

    public MyList()
    {
        array = new T[10];
    }

    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < count)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }
        array[count] = item;
        count++;
    }
}
