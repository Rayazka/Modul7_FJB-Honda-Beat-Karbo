namespace modul7_fjb_honda_beat_karbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilmFavorit_103022400006_josefhint dataFilmJo = new FilmFavorit_103022400006_josefhint();
            dataFilmJo.ReadJson();

            Watchlist_103022400006_josefhint dataWatchlistJo = new Watchlist_103022400006_josefhint();
            dataWatchlistJo.ReadJSON();
            Console.WriteLine();

            GenreDictionary_103022400006_josefhint dataGenreJo = new GenreDictionary_103022400006_josefhint();
            dataGenreJo.ReadJSON();

        }
    }
}