using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_fjb_honda_beat_karbo
{
    internal class FilmFavorit_103024400093
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
            string path = "D:\\Modul7_FJB-Honda-Beat-Karbo\\modul7_fjb-honda-beat-karbo\\jurnal7_1_103022400093.json";
            string jsonString = System.IO.File.ReadAllText(path);

            FilmFavorit_103024400093 dataFilm = System.Text.Json.JsonSerializer.Deserialize<FilmFavorit_103024400093>(jsonString);
            Console.WriteLine($"Title: {dataFilm.title}\nDirector: {dataFilm.director}\n Year: {dataFilm.year}\nGenre: {dataFilm.genre}\nRating: {dataFilm.rating}\nDuration (minutes): {dataFilm.durationMinutes}\nisWatched: {dataFilm.isWatched}");
        }
    }
}
