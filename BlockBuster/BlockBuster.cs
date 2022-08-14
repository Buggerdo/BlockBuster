using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster
{
    internal class BlockBuster
    {
        List<Movie> Movies = new();

        //Prints the list of movies
        public void PrintMovies()
        {
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie.Title);
            }
        }

        //Check a movie out
        public Movie CheckOut()
        {
            Console.WriteLine("What movie would you like to check out?");
            string movieTitle = Console.ReadLine();
            Movie movie = Movies.FirstOrDefault(m => m.Title == movieTitle);
            if (movie == null)
            {
                Console.WriteLine("That movie is not available.");
                return null;
            }
            else
            {
                Console.WriteLine("Enjoy the movie!");
                return movie;
            }
        }
    }
}
