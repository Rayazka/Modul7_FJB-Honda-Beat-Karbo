using System;
using System.Collections.Generic;
using System.Text;

namespace modul7_fjb_honda_beat_karbo
{
    internal class FilmFavorit_103022430002_RaflyPutra
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJson()
        {
            string path = "jurnal7_1_103022430002.json";
            string jsonString = System.IO.File.ReadAllText(path);

            FilmFavorit_103022430002_RaflyPutra dataFilm = System.Text.Json.JsonSerializer.Deserialize<FilmFavorit_103022430002_RaflyPutra>(jsonString);
            Console.WriteLine($"Title: {dataFilm.title}\nDirector: {dataFilm.director}\n Year: {dataFilm.year}\nGenre: {dataFilm.genre}\nRating: {dataFilm.rating}\nDuration (minutes): {dataFilm.durationMinutes}\nisWatched: {dataFilm.isWatched}");
        }
    }
}
