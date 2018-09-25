using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater myTheater = new Theater("MOVIETOWN");
            myTheater.Initialize();
            Movie zoolander = new Movie("Zoolander");
            // myTheater.Movies.Add(zoolander);
            myTheater.AddRoom(zoolander, 100);
            myTheater.PrintMovies();
            myTheater.AddShowtime("6:00", 0);

        }
    }
}
