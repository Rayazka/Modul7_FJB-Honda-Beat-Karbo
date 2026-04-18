using System;
using System.Collections.Generic;
using System.Text;

namespace modul7_fjb_honda_beat_karbo
{
    internal class FilmFavorit_103022400105
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJSON()
        {
            string path = "D:\\New folder\\Modul7_FJB-Honda-Beat-Karbo\\modul7_fjb-honda-beat-karbo\\jurnal7_1_103022400105.json";
            string jsonString = System.IO.File.ReadAllText(path);

            FilmFavorit_103022400105 filmFavFarrel = System.Text.Json.JsonSerializer.Deserialize<FilmFavorit_103022400105>(jsonString);
            Console.WriteLine($"Title: {filmFavFarrel.title}\nDirector: {filmFavFarrel.director}\n Year: {filmFavFarrel.year}\nGenre: {filmFavFarrel.genre}" +
                $"\nRating: {filmFavFarrel.rating}\nDuration (minutes): {filmFavFarrel.durationMinutes}\nisWatched: {filmFavFarrel.isWatched}");
        }
    }
}
