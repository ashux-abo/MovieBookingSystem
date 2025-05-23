using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSystem.Model;
using PaymentMethod;
namespace MovieBookingSystem
{
    public partial class MovieDetailsPage : Form
    {
        public MovieDetailsPage()
        {
            InitializeComponent();
          
        }

        private void subDescription_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void PopulateTheaterLocation()
        {
            List<string> items = new List<string>
            {
             "SM City North EDSA", "SM Mall of Asia", "SM Megamall", "SM City Manila", "SM City Fairview", "SM City San Lazaro",
            "SM City Marikina", "SM City San Mateo", "SM City Sucat", "SM City Bicutan", "SM City Taytay", "SM City Sta. Mesa",
            "SM City Novaliches", "SM City San Fernando", "SM City Clark", "SM City Pampanga", "SM City Batangas"
            };
            foreach (var item in items)
            {
                guna2ComboBox1.Items.Add(item);
            }
        }
        private void LoadMovieDetails()
        {
            // Check if movie data is available
            if (MovieDetails.movieCurrentInfo != null)
            {
                // Update the UI controls with movie data
                if (movieTitle != null)
                    movieTitle.Text = MovieDetails.movieCurrentInfo.MovieTitle;

                if (movieDescription != null)
                    movieDescription.Text = MovieDetails.movieCurrentInfo.MovieDescription;

                // If you have a genre label
                if (movieGenre != null)
                    movieGenre.Text = $"Genre: {MovieDetails.movieCurrentInfo.MovieGenre}";

                // If you have a duration label
                if (movieDuration != null)
                {
                    movieDuration.Text = MovieDetails.movieCurrentInfo.MovieDuration;
                    Console.WriteLine($"Duration set to: {MovieDetails.movieCurrentInfo.MovieDuration}"); // Debug line
                }
                else
                {
                    Console.WriteLine("movieDuration control is null - check control name in designer"); // Debug line
                }

                // Load movie poster image
                if (moviePosterImage != null && !string.IsNullOrEmpty(MovieDetails.movieCurrentInfo.MovieImage))
                {
                    try
                    {
                        moviePosterImage.Image = Image.FromFile(MovieDetails.movieCurrentInfo.MovieImage);
                        moviePosterImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading movie image: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No movie data available. Please select a movie first.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            PaymentMethodScreenBilling paymentMethodScreen = new PaymentMethodScreenBilling();
            paymentMethodScreen.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SeatSelection seatSelection = new SeatSelection();
            seatSelection.Show();
        }

        private void movieTitle_Click(object sender, EventArgs e)
        {

        }

        private void movieDescription_Click(object sender, EventArgs e)
        {

        }

        private void MovieDetailsPage_Load(object sender, EventArgs e)
        {
            PopulateTheaterLocation();
            LoadMovieDetails();
        }

        private string GetSelectedTheaterLocation()
        {
            return guna2ComboBox1.SelectedItem?.ToString() ?? string.Empty;
        }

        private string seatSelected = "";
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            seatSelected = "10:00 AM";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
