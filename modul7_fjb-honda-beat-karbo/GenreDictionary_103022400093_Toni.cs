using System;
using System.Collections.Generic;
using System.Text;

namespace modul7_fjb_honda_beat_karbo
{
    class GenreInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> popularMovies { get; set; }
    }

    class GenreDictionary
    {
        public string category { get; set; }
        public GenreInfo GenreInfo { get; set; }
    }

    internal class GenreDictionary_103022400093
    {
        public GenreDictionary GenreDictionary { get; set; }

        public void ReadJSON()
        {
            string path = "D:\\Modul7_FJB-Honda-Beat-Karbo\\modul7_fjb-honda-beat-karbo\\jurnal7_3_103022400093.json";
            string jsonString = System.IO.File.ReadAllText(path);
            GenreDictionary_103022400093 genreDict = System.Text.Json.JsonSerializer.Deserialize<GenreDictionary_103022400093>(jsonString);

            Console.WriteLine($"Category: {genreDict.GenreDictionary.category}");
            Console.WriteLine($"ID: {genreDict.GenreDictionary.GenreInfo.id}");
            Console.WriteLine($"Genre Name: {genreDict.GenreDictionary.GenreInfo.name}");
            Console.WriteLine($"Description: {genreDict.GenreDictionary.GenreInfo.description}");
            foreach (var movie in genreDict.GenreDictionary.GenreInfo.popularMovies)
            {

                Console.WriteLine($"Popular Movie: {movie}");
            }


        }
    }
}