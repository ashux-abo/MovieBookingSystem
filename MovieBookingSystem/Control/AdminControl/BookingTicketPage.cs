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
            PopulateTimeAvailable();
        }


        private void movieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.RowIndex < movieList.Rows.Count && !movieList.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow selectedRow = movieList.Rows[e.RowIndex];

        
                if (selectedRow.Tag is Movie movie)
                {
                    FDisplayMovieDetails(movie);
                }
                else
                {
                  
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
        private void PopulateTimeAvailable()
        {
            List<string> item = new List<string>
            {
                "10:00 AM",
                "01:00 PM",
                "04:00 PM",
                "07:00 PM",
                "10:00 PM"
            };
            foreach(var availableTime in item)
            {
                comboBox2.Items.Add(availableTime);
            }
        }
        private void PopulateMovieGrid()
        {
            movieList.Rows.Clear();

            if (movieList.Columns.Count == 0)
            {
                movieList.Columns.Add("Title", "Title");
                movieList.Columns.Add("Duration", "Duration");
                movieList.Columns.Add("Rating", "Rating");
            }

            foreach (var movie in movies)
            {
                int rowIndex = movieList.Rows.Add(movie.Title, movie.Duration, movie.Rating);
                movieList.Rows[rowIndex].Tag = movie;
            }
        }
        private void FDisplayMovieDetails(Movie movie)
        {
            movieTitle.Text = movie.Title;  
            movieGenre.Text = movie.Genre;  
            moviePrice.Text = movie.Price;  

            try
            {
                if (!string.IsNullOrEmpty(movie.ImagePath) && File.Exists(movie.ImagePath))
                {
                    moviePoster.Image = Image.FromFile(movie.ImagePath);
                }
                else
                {
                    moviePoster.Image = null;
                }
            }
            catch (Exception ex)
            {
                moviePoster.Image = null;
         
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
            ClearMovieSelection();
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


            foreach (DataGridViewRow row in movieList.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (string.IsNullOrEmpty(searchQuery))
                {
                    row.Visible = true;
                }
                else
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

            ClearMovieSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeatSelection seatSelection = new SeatSelection();
            seatSelection.ShowDialog();
        }
    }
}
