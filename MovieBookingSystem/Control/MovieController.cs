using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBookingSystem.Model;

namespace MovieBookingSystem.Control
{
    internal class MovieController
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();

        public List<Movie> GetMovies()
        {
            return databaseHelper.GetMovies();
        }
    }
}
