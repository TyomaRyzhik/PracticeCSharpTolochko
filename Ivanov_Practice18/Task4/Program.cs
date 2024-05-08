using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Hashtable spotifyCatalog = new Hashtable();

        // Добавление диска
        CD Spotify = new CD("Spotify");
        spotifyCatalog.Add(Spotify.Name, Spotify);

        // Добавление песни
        Spotify.AddSong("UNDEFEATED - Valorant");
        Spotify.AddSong("Karangilin - Valorant");
        Spotify.AddSong("Villain (Take the Shot) - Valorant");

        // Удаление песни
        Spotify.RemoveSong("UNDEFEATED - Valorant");

        // Просмотр содержимого диска
        Spotify.PrintSongs();

        // Просмотр каталога
        Console.WriteLine("Catalog:");
        foreach (CD cd in spotifyCatalog.Values)
        {
            Console.WriteLine(cd.Name);
        }
    }
}
