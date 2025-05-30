using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MovieBookingSystem.Model
{
    internal class DatabaseHelper
    {
        private string connectionString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True;Connection Timeout=30;";

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Movies";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie
                            {
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                ImagePath = reader["ImagePath"].ToString(),
                                Rating = reader["Rating"].ToString(),
                                Duration = reader["Duration"].ToString(),
                                Genre = reader["Genre"].ToString(),
                                Price = reader["Price"].ToString()
                            });
                        }
                    }
                }
            }
            return movies;
        }
    }
}
