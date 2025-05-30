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
using MovieBookingSystem.Control;
using MovieBookingSystem.Model;
using System.IO;

namespace MovieBookingSystem
{
    public partial class BookingTicketPage : UserControl
    {

        private List<Movie> movies = new List<Movie>();
        private MovieController movieController = new MovieController();
        public BookingTicketPage()
        {
            InitializeComponent();
            movieList.CellClick += movieList_CellClick;
            searchMovies.TextChanged += searchMovies_TextChanged;
        }
        private void LoadMovieDetails()
        {
            try
            {
                movies = movieController.GetMovies(); // Store movies in class variable
                PopulateMovieGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadMovieDetails();
        }


        private void movieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked (not header)
            if (e.RowIndex >= 0 && e.RowIndex < movieList.Rows.Count && !movieList.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow selectedRow = movieList.Rows[e.RowIndex];

                // Method 1: Get movie from Tag (recommended)
                if (selectedRow.Tag is Movie movie)
                {
                    FDisplayMovieDetails(movie);
                }
                else
                {
                    // Method 2: Fallback - search by title
                    string selectedMovieTitle = selectedRow.Cells[0].Value?.ToString();

                    if (!string.IsNullOrEmpty(selectedMovieTitle))
                    {
                        Movie foundMovie = movies.FirstOrDefault(m => m.Title == selectedMovieTitle);

                        if (foundMovie != null)
                        {
                            FDisplayMovieDetails(foundMovie);
                        }
                    }
                }
            }
        }
        private void PopulateMovieGrid()
        {
            movieList.Rows.Clear();

            // Configure DataGridView columns if not already done
            if (movieList.Columns.Count == 0)
            {
                movieList.Columns.Add("Title", "Title");
                movieList.Columns.Add("Duration", "Duration");
                movieList.Columns.Add("Rating", "Rating");
            }

            foreach (var movie in movies)
            {
                int rowIndex = movieList.Rows.Add(movie.Title, movie.Duration, movie.Rating);
                // Store the movie object in the row's Tag property for easy retrieval
                movieList.Rows[rowIndex].Tag = movie;
            }
        }
        private void FDisplayMovieDetails(Movie movie)
        {
            movieTitle.Text = movie.Title;  
            movieGenre.Text = movie.Genre;  
            moviePrice.Text = movie.Price;  

            // Handle image loading with error checking
            try
            {
                if (!string.IsNullOrEmpty(movie.ImagePath) && File.Exists(movie.ImagePath))
                {
                    moviePoster.Image = Image.FromFile(movie.ImagePath);
                }
                else
                {
                    moviePoster.Image = null; // or set a default "no image" placeholder
                }
            }
            catch (Exception ex)
            {
                moviePoster.Image = null;
                // For debuggin purposes
                Console.WriteLine($"Error loading image: {ex.Message}");
            }

            // Optional: Highlight the selected row
            foreach (DataGridViewRow row in movieList.Rows)
            {
                row.Selected = false;
            }

            // Find and select the current movie row
            foreach (DataGridViewRow row in movieList.Rows)
            {
                if (row.Tag is Movie rowMovie && rowMovie.Title == movie.Title)
                {
                    row.Selected = true;
                    break;
                }
            }
        }
        private void clearSelectedMovie_Click(object sender, EventArgs e)
        {

        }

        private void ClearMovieSelection()
        {
            movieTitle.Text = "";
            movieGenre.Text = "";
            moviePrice.Text = "";
            moviePoster.Image = null;


            movieList.ClearSelection();
        }
        private void searchMovies_TextChanged(object sender, EventArgs e)
        {
            FilterMovies();
        }

        private void FilterMovies()
        {
            string searchQuery = searchMovies.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                // Show all movies if search is empty
                foreach (DataGridViewRow row in movieList.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                // Filter movies based on search query
                foreach (DataGridViewRow row in movieList.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string movieTitle = row.Cells[0].Value.ToString().ToLower();
                        row.Visible = movieTitle.Contains(searchQuery);
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            // Clear selection when filtering
            ClearMovieSelection();
        }
    }
}
