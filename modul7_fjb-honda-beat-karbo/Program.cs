namespace modul7_fjb_honda_beat_karbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103024400096 dataFilmRay = new FilmFavorit_103024400096();
            dataFilmRay.ReadJson();
            Console.WriteLine();

            Watchlist_103022400096 dataWatchlistRay = new Watchlist_103022400096();
            dataWatchlistRay.ReadJSON();
            Console.WriteLine();

            GenreDictionary_103022400096 dataGenreRay = new GenreDictionary_103022400096();
            dataGenreRay.ReadJSON();
        }
    }
}