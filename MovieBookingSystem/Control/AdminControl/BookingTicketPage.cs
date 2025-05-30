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
        private string selectedTime = "";
        private List<Movie> movies = new List<Movie>();
        private MovieController movieController = new MovieController();
        private string connectionString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True;Connection Timeout=30;";
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

            foreach (DataGridViewRow row in movieList.Rows)
            {
                row.Selected = false;
            }

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
        private DateTime ConvertTimeStringToDateTime(string timeString)
        {
            DateTime dateTime = DateTime.Now;

            switch (timeString)
            {
                case "10:00 AM":
                    return dateTime = dateTime.Date.AddHours(10);
                case "11:45 AM":
                    return dateTime = dateTime.Date.AddHours(11).AddMinutes(45);
                case "1:00PM":
                    return dateTime = dateTime.Date.AddHours(13);
                case "2:45PM":
                    return dateTime = dateTime.Date.AddHours(14).AddMinutes(45);
                case "4:00PM":
                    return dateTime = dateTime.Date.AddHours(16);
                default:
                    return dateTime = dateTime.AddHours(10);
            }

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTime))
            {
                MessageBox.Show("Please select a showtime first.");
                return;
            }

            if (movieList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }
            try
            {
                DateTime showTime = ConvertTimeStringToDateTime(selectedTime);
                SeatSelection seatSelection = new SeatSelection(showTime);
                seatSelection.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening seat selection: {ex.Message}");
            }
        }
        private double moviePriceValue = 0.00;
        private void button7_Click(object sender, EventArgs e)
        {
            if (movieList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }

            string query = "SELECT Price FROM Movies WHERE Title = @Title";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", movieList.SelectedRows[0].Cells["Title"].Value);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        if (double.TryParse(result.ToString(), out moviePriceValue))
                        {
                            moviePrice.Text = moviePriceValue.ToString("C"); // Currency format
                            displayPrice.Text = moviePriceValue.ToString("F2"); // Decimal format
                        }
                        else
                        {
                            MessageBox.Show("Invalid price format in database.");
                            moviePriceValue = 0.00; 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Movie not found or price is null.");
                        moviePriceValue = 0.00; 
                    }
                }
            }
        }

        private void CalculateAndDisplayChange(double price, double payment)
        {
            var calc = new CalculateFee(price, payment);
            double change = calc.CalculateTotalFee();
            displayChange.Text = change.ToString("F2"); 
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedTime = comboBox2.SelectedItem?.ToString() ?? "";
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if(payment.Text == "")
            {
                MessageBox.Show("Please enter a payment amount.");
                return;
            }
            CalculateAndDisplayChange(350.00, Convert.ToInt32(payment.Text)); 
        }
    }
}
