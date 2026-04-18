namespace modul7_fjb_honda_beat_karbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103022400105 filmFavFarrel = new FilmFavorit_103022400105();
            filmFavFarrel.ReadJSON();

            Console.WriteLine();

            Watchlist_103022400105 dataWatchlistFarrel = new Watchlist_103022400105();
            dataWatchlistFarrel.ReadJSON();
            Console.WriteLine();

            Console.WriteLine();

            GenreDictionary_103022400105 dataGenreRay = new GenreDictionary_103022400105();
            dataGenreRay.ReadJSON();

            FilmFavorit_103024400096 dataFilmRay = new FilmFavorit_103024400096();
            dataFilmRay.ReadJson();
        }
    }
}
