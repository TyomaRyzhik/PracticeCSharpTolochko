using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Использование абстрактных структур
        List<Game> gamesList = new List<Game>();
        Dictionary<string, Game> gamesDictionary = new Dictionary<string, Game>();

        // Добавление игры
        Game game1 = new Game("Game1", 100);
        gamesList.Add(game1);
        gamesDictionary.Add(game1.Name, game1);

        // Клонирование игры
        Game game2 = game1.Clone();
        game2.Name = "Game2";
        gamesList.Add(game2);
        gamesDictionary.Add(game2.Name, game2);


        // Удаление игры
        gamesList.Remove(game1);
        gamesDictionary.Remove(game1.Name);

        // Вывод игр
        foreach (var game in gamesList)
        {
            Console.WriteLine($"Name: {game.Name}, Score: {game.Score}");
        }
    }
}
