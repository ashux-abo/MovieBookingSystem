using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingSystem
{
    public partial class MainPage : Form
    {
        private List<Movie> movies = new List<Movie>();
        private bool isSideBarExpanded = false;
        private const int SidebarWidth = 200;

        public MainPage()
        {
            InitializeComponent();
            InitializeMovies();
            SetupMovieCards();
            SetupSearchBar();
            SetupNavigation();
        }

        private void InitializeMovies()
        {
            // Add sample movies - you can replace these with your actual movie data
            movies.Add(new Movie
            {
                Title = "Spider-Man: Across the Spider-Verse",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter.jpeg",
                Description = "Miles Morales returns for the next chapter of the Oscar-winning Spider-Verse saga.",
                Rating = "PG",
                Duration = "2h 20m"
            });

            movies.Add(new Movie
            {
                Title = "Minecraft: The Movie",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
                Description = "A live-action adaptation of the popular video game Minecraft.",
                Rating = "PG-13",
                Duration = "1h 45m"
            });
        }

        private void SetupMovieCards()
        {
            flowLayoutPanel1.Controls.Clear();
            int cardWidth = 200;
            int cardHeight = 300;

            foreach (var movie in movies)
            {
                var card = new Guna.UI2.WinForms.Guna2Panel();
                card.Size = new Size(cardWidth, cardHeight);
                card.FillColor = Color.FromArgb(30, 31, 32);
                card.BorderRadius = 10;
                card.ShadowDecoration.Enabled = true;
                card.ShadowDecoration.Depth = 10;
                card.Margin = new Padding(10);

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

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ShowMoviePreview(Movie movie, Control card)
        {
            var preview = new Guna.UI2.WinForms.Guna2Panel();
            preview.Size = new Size(300, 400);
            preview.Location = new Point(card.Right + 20, card.Top);
            preview.FillColor = Color.FromArgb(40, 41, 42);
            preview.BorderRadius = 10;
            preview.ShadowDecoration.Enabled = true;
            preview.ShadowDecoration.Depth = 10;

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
            descLabel.Size = new Size(260, 60);
            descLabel.AutoSize = false;

            var ratingLabel = new Label();
            ratingLabel.Text = $"Rating: {movie.Rating}";
            ratingLabel.ForeColor = Color.White;
            ratingLabel.Font = new Font("Segoe UI", 10);
            ratingLabel.Location = new Point(20, 130);
            ratingLabel.AutoSize = true;

            var durationLabel = new Label();
            durationLabel.Text = $"Duration: {movie.Duration}";
            durationLabel.ForeColor = Color.White;
            durationLabel.Font = new Font("Segoe UI", 10);
            durationLabel.Location = new Point(20, 160);
            durationLabel.AutoSize = true;

            preview.Controls.Add(titleLabel);
            preview.Controls.Add(descLabel);
            preview.Controls.Add(ratingLabel);
            preview.Controls.Add(durationLabel);

            preview.Tag = "preview";
            guna2Panel1.Controls.Add(preview);
            preview.BringToFront();
        }

        private void HideMoviePreview()
        {
            var preview = guna2Panel1.Controls.Find("preview", true).FirstOrDefault();
            if (preview != null)
            {
                guna2Panel1.Controls.Remove(preview);
            }
        }

        private void SetupSearchBar()
        {
            guna2TextBox1.PlaceholderText = "Search movies...";
            guna2TextBox1.TextChanged += (s, e) =>
            {
                string searchText = guna2TextBox1.Text.ToLower();
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

        private void SetupNavigation()
        {
            guna2Button2.Click += (s, e) => { /* Already on dashboard */ };
            guna2Button3.Click += (s, e) => 
            {
                // Open seat selection form
                Form1 seatSelection = new Form1();
                seatSelection.Show();
                this.Hide();
            };
            guna2Button4.Click += (s, e) => 
            {
                // Open customer support form
                MessageBox.Show("Customer support feature coming soon!");
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

        private void timeSideBar_Tick(object sender, EventArgs e)
        {
            int step = 20;
            if (isSideBarExpanded)
            {
                panel2.Location = new Point(panel2.Location.X - step, panel2.Location.Y);
                if (panel2.Location.X <= -SidebarWidth)
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = false;
                }
            }
            else
            {
                panel2.Location = new Point(panel2.Location.X + step, panel2.Location.Y);
                if (panel2.Location.X >= 0)
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = true;
                }
            }
        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }
    }
}
