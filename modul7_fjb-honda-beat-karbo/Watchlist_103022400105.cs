using System;
using System.Collections.Generic;
using System.Text;

namespace modul7_fjb_honda_beat_karbo
{
    class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }

    internal class Watchlist_103022400105
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Movie> movies { get; set; }

        public void ReadJSON()
        {
            string path = "D:\\New folder\\Modul7_FJB-Honda-Beat-Karbo\\modul7_fjb-honda-beat-karbo\\jurnal7_2_103022400105.json";
            string jsonString = System.IO.File.ReadAllText(path);
            Watchlist_103022400105 watchlist = System.Text.Json.JsonSerializer.Deserialize<Watchlist_103022400105>(jsonString);
            Console.WriteLine($"Watchlist Name: {watchlist.watchlistName}");
            Console.WriteLine($"Created By: {watchlist.createdBy}");
            Console.WriteLine("Movies:");
            foreach (var movie in watchlist.movies)
            {
                Console.WriteLine($"{movie.id} {movie.title} ({movie.year}) - {movie.rating}");
            }
        }
    }
}
