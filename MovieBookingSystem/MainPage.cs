using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSystem.Model;

namespace MovieBookingSystem
{
    public partial class MainPage : Form
    {
        private List<Movie> movies = new List<Movie>();
        private const int SidebarWidth = 200;

        private void FlowLayoutPanel(Control flowlayoutpanel)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = flowlayoutpanel.Width;
            int panelHeight = flowlayoutpanel.Height;

            flowlayoutpanel.Location = new Point(
                (formWidth - panelWidth) / 2,
                (formHeight - panelHeight) / 2
            );
        }

        public MainPage()
        {
            InitializeComponent();
            InitializeMovies();
            SetupMovieCards();
            SetupSearchBar();
            FlowLayoutPanel(flowLayoutPanel1);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            FlowLayoutPanel(flowLayoutPanel1); // Keeps it centered dynamically
        }

        private void InitializeMovies()
        {
            // Add sample movies - you can replace these with your actual movie data
            movies.Add(new Movie
            {
                Title = "Spider-Man: Across the Spider-Verse",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "Miles Morales returns for the next chapter of the Oscar-winning Spider-Verse saga.",
                Rating = "PG",
                Duration = "2h 20m",
                Genre = "Animation, Action, Adventure" // Added Genre property
            });

            movies.Add(new Movie
            {
                Title = "Minecraft: The Movie",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
                Description = "A live-action adaptation of the popular video game Minecraft.",
                Rating = "PG-13",
                Duration = "1h 45m",
                Genre = "Adventure, Comedy, Family"
            });

            movies.Add(new Movie
            {
                Title = "Final Destination: Bloodline",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\finaldestination6-exhibition-onesheet.jpg",
                Description = "Plagued by a violent and recurring nightmare, a college student heads home to track\r\ndown the one person who might be able to break the cycle of death and save her\r\nfamily from the grisly demise that inevitably awaits them all.",
                Rating = "PG-13",
                Duration = "2h 28m",
                Genre = "Horror, Thriller"
            });

            movies.Add(new Movie
            {
                Title = "Interstellar",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "A team of explorers travel through a wormhole in search of a new home for humanity.",
                Rating = "PG-13",
                Duration = "2h 49m",
                Genre = "Sci-Fi, Drama"
            });

            movies.Add(new Movie
            {
                Title = "John Wick: Chapter 4",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "John Wick faces his toughest challenge yet as he fights for survival against a powerful new enemy.",
                Rating = "R",
                Duration = "2h 49m",
                Genre = "Action, Crime, Thriller"
            });

            movies.Add(new Movie
            {
                Title = "Avatar: The Way of Water",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "Jake Sully and Neytiri must protect their family from new threats in the oceans of Pandora.",
                Rating = "PG-13",
                Duration = "3h 12m",
                Genre = "Sci-Fi, Adventure, Action"
            });

            movies.Add(new Movie
            {
                Title = "The Super Mario Bros. Movie",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "Mario and Luigi embark on an adventure to save the Mushroom Kingdom.",
                Rating = "PG",
                Duration = "1h 32m",
                Genre = "Animation, Adventure, Comedy"
            });
        }

        private void SetupMovieCards()
        {
            flowLayoutPanel1.Controls.Clear();
            int cardWidth = 200;
            int cardHeight = 300;

            foreach (var movie in movies)
            {
                // Create a movie card from our custom control
                var card = CreateMovieCard(movie, cardWidth, cardHeight);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private Guna.UI2.WinForms.Guna2Panel CreateMovieCard(Movie movie, int cardWidth, int cardHeight)
        {
            var card = new Guna.UI2.WinForms.Guna2Panel();
            card.Size = new Size(cardWidth, cardHeight);
            card.FillColor = Color.FromArgb(30, 31, 32);
            card.BorderRadius = 10;
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 10;
            card.Margin = new Padding(10);
            card.Tag = movie; // Store the movie object in the Tag property for easy access

            var pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            pictureBox.Size = new Size(cardWidth, cardHeight - 60);
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(movie.ImagePath);
            pictureBox.BorderRadius = 10;

            var titleLabel = new Label();
            titleLabel.Text = movie.Title;
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            titleLabel.Location = new Point(10, cardHeight - 50);
            titleLabel.AutoSize = true;

            card.Controls.Add(pictureBox);
            card.Controls.Add(titleLabel);

            // Add hover effect
            card.MouseEnter += (s, e) => ShowMoviePreview(movie, card);
            card.MouseLeave += (s, e) => HideMoviePreview();

            // Add click event to navigate to movie details page
            card.Click += (s, e) => OpenMovieDetails(movie);
            pictureBox.Click += (s, e) => OpenMovieDetails(movie);
            titleLabel.Click += (s, e) => OpenMovieDetails(movie);

            // Change cursor on hover to indicate it's clickable
            card.Cursor = Cursors.Hand;
            pictureBox.Cursor = Cursors.Hand;
            titleLabel.Cursor = Cursors.Hand;

            return card;
        }

        private void ShowMoviePreview(Movie movie, Control card)
        {
            HideMoviePreview(); // Hide any existing preview first

            var preview = new Guna.UI2.WinForms.Guna2Panel();
            preview.Size = new Size(300, 400);
            preview.Location = new Point(card.Right + 20, card.Top);

            // Adjust the position if it goes off-screen
            if (preview.Right > this.ClientSize.Width)
            {
                preview.Location = new Point(card.Left - 320, card.Top);
            }

            preview.FillColor = Color.FromArgb(40, 41, 42);
            preview.BorderRadius = 10;
            preview.ShadowDecoration.Enabled = true;
            preview.ShadowDecoration.Depth = 10;
            preview.Name = "previewPanel";

            var titleLabel = new Label();
            titleLabel.Text = movie.Title;
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.AutoSize = true;

            var descLabel = new Label();
            descLabel.Text = movie.Description;
            descLabel.ForeColor = Color.White;
            descLabel.Font = new Font("Segoe UI", 10);
            descLabel.Location = new Point(20, 60);
            descLabel.Size = new Size(260, 100);
            descLabel.AutoSize = false;

            var ratingLabel = new Label();
            ratingLabel.Text = $"Rating: {movie.Rating}";
            ratingLabel.ForeColor = Color.White;
            ratingLabel.Font = new Font("Segoe UI", 10);
            ratingLabel.Location = new Point(20, 170);
            ratingLabel.AutoSize = true;

            var durationLabel = new Label();
            durationLabel.Text = $"Duration: {movie.Duration}";
            durationLabel.ForeColor = Color.White;
            durationLabel.Font = new Font("Segoe UI", 10);
            durationLabel.Location = new Point(20, 200);
            durationLabel.AutoSize = true;

            // Add a "Book Now" button
            var bookButton = new Guna.UI2.WinForms.Guna2Button();
            bookButton.Text = "Book Now";
            bookButton.Size = new Size(260, 40);
            bookButton.Location = new Point(20, 240);
            bookButton.FillColor = Color.FromArgb(227, 58, 77);
            bookButton.BorderRadius = 5;
            bookButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            bookButton.Click += (s, e) => OpenMovieDetails(movie);
            bookButton.Cursor = Cursors.Hand;

            // Add a "View Details" button
            var detailsButton = new Guna.UI2.WinForms.Guna2Button();
            detailsButton.Text = "View Details";
            detailsButton.Size = new Size(260, 40);
            detailsButton.Location = new Point(20, 290);
            detailsButton.FillColor = Color.FromArgb(94, 148, 255);
            detailsButton.BorderRadius = 5;
            detailsButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            detailsButton.Click += (s, e) => OpenMovieDetails(movie);
            detailsButton.Cursor = Cursors.Hand;

            preview.Controls.Add(titleLabel);
            preview.Controls.Add(descLabel);
            preview.Controls.Add(ratingLabel);
            preview.Controls.Add(durationLabel);
            preview.Controls.Add(bookButton);
            preview.Controls.Add(detailsButton);

            this.Controls.Add(preview);
            preview.BringToFront();
        }

        private void HideMoviePreview()
        {
            // Find and remove any existing preview panel
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name == "previewPanel")
                {
                    this.Controls.Remove(ctrl);
                    ctrl.Dispose();
                    break;
                }
            }
        }

        private void OpenMovieDetails(Movie movie)
        {
            // Set the current movie info in the static property
            MovieDetails.movieCurrentInfo = new MovieDetails(
                movie.Title,
                movie.Description,
                movie.ImagePath,
                movie.Genre, 
                movie.Duration
            );

            // Create and show the movie details form
            MovieDetailsPage detailsPage = new MovieDetailsPage();
            detailsPage.Show();
        }

        private void SetupSearchBar()
        {
            searchBox.PlaceholderText = "Search movies...";
            searchBox.TextChanged += (s, e) =>
            {
                string searchText = searchBox.Text.ToLower();
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Guna.UI2.WinForms.Guna2Panel card)
                    {
                        var titleLabel = card.Controls.OfType<Label>().FirstOrDefault();
                        if (titleLabel != null)
                        {
                            card.Visible = titleLabel.Text.ToLower().Contains(searchText);
                        }
                    }
                }
            };
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(-SidebarWidth, 40);
            panel2.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timeSideBar.Interval = 10;
            timeSideBar.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Not needed but kept for form designer compatibility
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SeatSelection seatSelection = new SeatSelection();
            seatSelection.Show();
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
    }
}