using System;
using System.Collections;
using System.Collections.Generic;

public class CD
{
    public string Name { get; set; }
    public List<string> Songs { get; set; }

    public CD(string name)
    {
        this.Name = name;
        this.Songs = new List<string>();
    }

    public void AddSong(string song)
    {
        this.Songs.Add(song);
    }

    public void RemoveSong(string song)
    {
        this.Songs.Remove(song);
    }

    public void PrintSongs()
    {
        Console.WriteLine($"Songs in {this.Name}:");
        foreach (string song in this.Songs)
        {
            Console.WriteLine(song);
        }
    }
}