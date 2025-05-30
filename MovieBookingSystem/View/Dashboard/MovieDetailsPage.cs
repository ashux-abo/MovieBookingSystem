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
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace MovieBookingSystem
{
    public partial class MovieDetailsPage : Form
    {
        private string selectedTime = "";
        private Guna2Button selectedTimeButton = null; 
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
        private void PopulateAvailableCinema()
        {
            List<string> items = new List<string>
            {
               "CINEMA 1", "CINEMA 2", "CINEMA 3", "CINEMA 4", "CINEMA 5", "CINEMA 6",
            };
            availableCinema.Items.Insert(0, "Select Cinema"); 
            availableCinema.SelectedIndex = 0; 
            foreach (var item in items)
            {
                availableCinema.Items.Add(item);
            }
            
        }
        private void PopulateTheaterLocation()
        {
            List<string> items = new List<string>
            {
             "SM City North EDSA", "SM Mall of Asia", "SM Megamall", "SM City Manila", "SM City Fairview", "SM City San Lazaro",
            "SM City Marikina", "SM City San Mateo", "SM City Sucat", "SM City Bicutan", "SM City Taytay", "SM City Sta. Mesa",
            "SM City Novaliches", "SM City San Fernando", "SM City Clark", "SM City Pampanga", "SM City Batangas"
            };
            guna2ComboBox1.Items.Insert(0, "Select Location"); 
            guna2ComboBox1.SelectedIndex = 0;
            foreach (var item in items)
            {
                guna2ComboBox1.Items.Add(item);
            }
        }
        private void LoadMovieDetails()
        {
            if (MovieDetails.movieCurrentInfo != null)
            {
   
                if (movieTitle != null)
                    movieTitle.Text = MovieDetails.movieCurrentInfo.MovieTitle;

                if (movieDescription != null)
                    movieDescription.Text = MovieDetails.movieCurrentInfo.MovieDescription;

                if (movieGenre != null)
                    movieGenre.Text = $"Genre: {MovieDetails.movieCurrentInfo.MovieGenre}";

                if (movieDuration != null)
                {
                    movieDuration.Text = MovieDetails.movieCurrentInfo.MovieDuration;
                    Console.WriteLine($"Duration set to: {MovieDetails.movieCurrentInfo.MovieDuration}");
                }
                else
                {
                    Console.WriteLine("movieDuration control is null - check control name in designer"); 
                }


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
                if(moviePrice != null)
                {
                    moviePrice.Text = MovieDetails.movieCurrentInfo.MoviePrice;
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
            if (string.IsNullOrEmpty(selectedTime))
            {
                MessageBox.Show("Please select a showtime first.");
                return;
            }

            if (MovieDetails.movieCurrentInfo == null)
            {
                MessageBox.Show("No movie selected.");
                return;
            }

            try
            {
                int movieId = MovieDetails.movieCurrentInfo.MovieId; 
                string movieTitle = MovieDetails.movieCurrentInfo.MovieTitle;

                DateTime showTime = ConvertTimeStringToDateTime(selectedTime);

                SeatSelection seatSelection = new SeatSelection(movieId, movieTitle, showTime);
                seatSelection.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening seat selection: {ex.Message}");
            }
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
        private void SelectTimeButton(Guna2Button clickedButton, string time)
        {
            if (selectedTimeButton != null)
            {
                selectedTimeButton.FillColor = Color.Transparent; 
            }

            selectedTimeButton = clickedButton;
            selectedTimeButton.FillColor = Color.White; 
            selectedTime = time;
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
            PopulateAvailableCinema();
            LoadMovieDetails();
            LoadRecommendationMoive();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SelectTimeButton((Guna2Button)sender, "10:00 AM");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           SelectTimeButton((Guna2Button)sender, "11:45 AM");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SelectTimeButton((Guna2Button)sender, "1:00PM");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SelectTimeButton((Guna2Button)sender, "2:45PM");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SelectTimeButton((Guna2Button)sender, "4:00PM");
        }

        private void RecommendationPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void LoadRecommendationMoive()
        {
            List<string> list = new List<string>()
            {
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\avatar_the_way_of_water.jpg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\finaldestination6-exhibition-onesheet.jpg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\interstellarposter.jpeg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\john_wick_chapter_four_ver2.jpg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\super_mario_bros_the_movie_ver2.jpg",
                "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\demon-slayer-mugen-train.jpg"
            };
            RecommendationPanel.Controls.Clear();
            foreach (var item in list)
            {
                PictureBox picture = new PictureBox();
                picture.Image = Image.FromFile(item);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Size = new Size(170, 230); 
                picture.Margin = new Padding(10);

                RecommendationPanel.Controls.Add(picture);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
