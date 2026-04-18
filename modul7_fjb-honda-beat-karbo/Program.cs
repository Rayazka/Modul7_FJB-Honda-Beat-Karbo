namespace modul7_fjb_honda_beat_karbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103022430002_RaflyPutra dataFilmRafly = new FilmFavorit_103022430002_RaflyPutra();
            dataFilmRafly.ReadJson();

            Watchlist_103022430002 dataWatchlistRafly = new Watchlist_103022430002();
            dataWatchlistRafly.ReadJSON();
            Console.WriteLine();

            GenreDictionary_103022430002 dataGenreRay = new GenreDictionary_103022430002();
            dataGenreRay.ReadJSON();
        }
    }
}