namespace modul7_fjb_honda_beat_karbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103024400093 dataFilmToni = new FilmFavorit_103024400093();
            dataFilmToni.ReadJson();
            Console.WriteLine();

            Watchlist_103022400093 dataWatchlistToni = new Watchlist_103022400093();
            dataWatchlistToni.ReadJSON();
            Console.WriteLine();
        }
    }
}