using System;
class IntArrayVector : IComparable<IntArrayVector>
    {
    private int[] vector;

    // Конструктор для задания произвольных границ индексов
    public IntArrayVector(int lowerIndex, int upperIndex)
    {
        if (lowerIndex > upperIndex)
            throw new ArgumentException("Lower index cannot be greater than upper index.");

        int size = upperIndex - lowerIndex + 1;
        vector = new int[size];
    }

    // Обращение к элементу массива с контролем выхода за пределы
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= vector.Length)
                throw new IndexOutOfRangeException("Index is out of range.");
            return vector[index];
        }
        set
        {
            if (index < 0 || index >= vector.Length)
                throw new IndexOutOfRangeException("Index is out of range.");
            vector[index] = value;
        }
    }

    // Выполнение операции поэлементного сложения массивов с одинаковыми границами индексов
    public static IntArrayVector operator +(IntArrayVector v1, IntArrayVector v2)
    {
        if (v1.vector.Length != v2.vector.Length)
            throw new ArgumentException("Vectors must have the same length for addition.");
        IntArrayVector result = new IntArrayVector(0, v1.vector.Length - 1);
        for (int i = 0; i < v1.vector.Length; i++)
            result[i] = v1[i] + v2[i];
        return result;
    }

    // Выполнение операции поэлементного вычитания массивов с одинаковыми границами индексов
    public static IntArrayVector operator -(IntArrayVector v1, IntArrayVector v2)
    {
        if (v1.vector.Length != v2.vector.Length)
            throw new ArgumentException("Vectors must have the same length for subtraction.");
        IntArrayVector result = new IntArrayVector(0, v1.vector.Length - 1);
        for (int i = 0; i < v1.vector.Length; i++)
            result[i] = v1[i] - v2[i];
        return result;
    }

    // Вывод на экран элемента массива по заданному индексу и всего массива
    public void PrintElement(int index)
    {
        Console.WriteLine($"Element at index {index}: {this[index]}");
    }

    public void PrintVector()
    {
        Console.Write("Vector: ");
        foreach (int element in vector)
            Console.Write(element + " ");
        Console.WriteLine();
    }

    // Реализация интерфейса IComparable
    public int CompareTo(IntArrayVector other)
    {
        // Сравниваем сумму элементов векторов
        int sumThis = 0;
        int sumOther = 0;
        foreach (int element in vector)
            sumThis += element;
        foreach (int element in other.vector)
            sumOther += element;
        return sumThis.CompareTo(sumOther);
    }
}