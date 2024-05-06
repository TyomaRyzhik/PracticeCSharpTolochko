using System;

class Program
{
    static void Main()
    {
        // Создаем новый экземпляр MyDictionary
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        // Добавляем пары ключ-значение
        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        // Выводим количество элементов в словаре
        Console.WriteLine($"Количество элементов: {myDictionary.Count}");

        // Получаем и выводим значения по ключам
        Console.WriteLine($"Значение по ключу 'one': {myDictionary["one"]}");
        Console.WriteLine($"Значение по ключу 'two': {myDictionary["two"]}");
        Console.WriteLine($"Значение по ключу 'three': {myDictionary["three"]}");

        Console.ReadLine();
    }
}
