using System;

public class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count = 0;

    public MyDictionary()
    {
        keys = new TKey[10];
        values = new TValue[10];
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            throw new ArgumentException("Key not found");
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }
}
