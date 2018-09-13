using System;
using System.Collections.Generic;

namespace KillNickleBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            HashSet<Song> allSongs = new HashSet<Song>();

            allSongs.Add(new Song("Nickleback", "If today was your last day"));
            allSongs.Add(new Song("Bryan Adams", "Please Forgive me"));
            allSongs.Add(new Song("Taylor Swift", "Shake it off"));
            allSongs.Add(new Song("Nickleback", "How you remind me"));
            allSongs.Add(new Song("Nickleback", "Far away"));
            allSongs.Add(new Song("Back Street Boys", "I want it that way"));
            allSongs.Add(new Song("Nickleback", "How you remind me"));

            foreach (var song in allSongs)
            {
                if (song.Artist != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }
            Console.WriteLine("ALL THE GOOD SONGS: ");
            Console.WriteLine();
            foreach ( var goodsong in goodSongs)
            {
                Console.WriteLine($"{goodsong.Name}");
            }

            Console.ReadLine();
        }

    }
}

