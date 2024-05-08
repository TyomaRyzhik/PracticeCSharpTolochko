using System;
using System.Collections.Generic;

public class Game
{
    public string Name { get; set; }
    public int? Score { get; set; } // Обнуляемый тип

    public Game(string name, int? score)
    {
        this.Name = name;
        this.Score = score;
    }

    public Game Clone()
    {
        return new Game(this.Name, this.Score);
    }
}