using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using MovieBookingSystem.Control;

namespace MovieBookingSystem
{
    public partial class BookingTicketPage : UserControl
    {
       
        public BookingTicketPage()
        {
            InitializeComponent();
            movieList.CellClick += movieList_CellClick;
            searchMovies.TextChanged += searchMovies_TextChanged;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void BookingTicketPage_Load(object sender, EventArgs e)
        {
           movieDetails();
          

        }
        private List<Movie> movie = new List<Movie>();
        private MovieController movieController = new MovieController();
        private void movieDetails()
        {
            List<Movie> movies = movieController.GetMovies();
            movieList.Rows.Clear();
            foreach (var item in movies)
            {
                movieList.Rows.Add(item.Title, item.Duration, item.Rating);
            }



        }

        private void movieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < movieList.Rows.Count)
            {
                string selectedMovies = movieList.Rows[e.RowIndex].Cells[0].Value.ToString();

                Movie selectedMovie = null;

                foreach (var item in movie)
                {
                    if (item.Title == selectedMovies)
                    {
                        selectedMovie = item;
                        break;
                    }
                }
                if (selectedMovie != null)
                {
                    // Display the selected movie details
                    movieTitle.Text = selectedMovie.Title;
                    movieGenre.Text = selectedMovie.Duration;
                    moviePrice.Text = selectedMovie.Price;
                    // Load the movie poster image
                    moviePoster.Image = Image.FromFile(selectedMovie.ImagePath);
                }
            }
        }

        private void clearSelectedMovie_Click(object sender, EventArgs e)
        {
            movieTitle.Text = "";
            movieGenre.Text = "";
            moviePrice.Text = "";
            moviePoster.Image = null; // Clear the image
        }
        //A Static Method to Populate Movie Details
       /* private void PopulateStaticMovieDetails()
        {
            movie.Add(new Movie
            {
                Title = "Spider-Man: Across the Spider-Verse",
                Description = "Miles Morales returns for the next chapter of the Oscar-winning Spider-Verse saga.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Rating = "PG",
                Duration = "2h 20m",
                Genre = "Animation, Action, Adventure",
                Price = "P350.00"
            });

            movie.Add(new Movie
            {
                Title = "John Wick: Chapter 4",
                Description = "John Wick uncovers a path to defeating the High Table.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\john_wick_chapter_four_ver2.jpg",
                Rating = "R-18",
                Duration = "2h 49m",
                Genre = "Action, Crime, Thriller",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Interstellar",
                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\interstellarposter.jpeg",
                Rating = "PG-13",
                Duration = "2h 49m",
                Genre = "Adventure, Drama, Sci-Fi",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Avatar: The Way of Water",
                Description = "Jake Sully and Ney'tiri have formed a family and are doing anything to stay together.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\avatar_the_way_of_water.jpg",
                Rating = "PG-13",
                Duration = "3h 12m",
                Genre = "Action, Adventure, Fantasy",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Super Mario Bros. Movie",
                Description = "A plumber named Mario travels through an underground labyrinth with his brother, Luigi, trying to save a captured princess.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\super_mario_bros_the_movie_ver2.jpg",
                Rating = "PG",
                Duration = "1h 32m",
                Genre = "Animation, Adventure, Comedy",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Demon Slayer: Mugen Train",
                Description = "Tanjiro Kamado joins the Demon Slayer Corps to defeat demons and protect humanity.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\demon-slayer-mugen-train.jpg",
                Rating = "R-18",
                Duration = "1h 57m",
                Genre = "Animation, Action, Adventure",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Final Destination 6",
                Description = "A group of friends escape death's design and must find a way to survive.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\finaldestination6-exhibition-onesheet.jpg",
                Rating = "R-18",
                Duration = "1h 30m",
                Genre = "Horror, Thriller",
                Price = "P350.00"
            });
            movie.Add(new Movie
            {
                Title = "Minecraft: The Movie",
                Description = "A group of friends embark on a journey to save their world from destruction.",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
                Rating = "PG",
                Duration = "1h 45m",
                Genre = "Adventure, Family, Fantasy",
                Price = "P350.00"
            });
            // Populate the DataGridView with movie details
        }*/

        private void searchMovies_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchMovies.Text.ToLower();

            foreach(DataGridViewRow row in movieList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(searchQuery))
                {
                    row.Visible = true; // Show the row if it matches the search query
                }
                else
                {
                    row.Visible = false; // Hide the row if it doesn't match
                }
            }
        }
    }
}
