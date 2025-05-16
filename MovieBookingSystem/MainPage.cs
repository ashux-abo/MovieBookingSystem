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
            this.WindowState = FormWindowState.Maximized;
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
            movies.Add(new Movie
            {
                Title = "Inception",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "A thief who enters people's dreams to steal secrets must complete an impossible mission.",
                Rating = "PG-13",
                Duration = "2h 28m"
            });

            movies.Add(new Movie
            {
                Title = "Interstellar",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "A team of explorers travel through a wormhole in search of a new home for humanity.",
                Rating = "PG-13",
                Duration = "2h 49m"
            });

            movies.Add(new Movie
            {
                Title = "John Wick: Chapter 4",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "John Wick faces his toughest challenge yet as he fights for survival against a powerful new enemy.",
                Rating = "R",
                Duration = "2h 49m"
            });

            movies.Add(new Movie
            {
                Title = "Avatar: The Way of Water",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "Jake Sully and Neytiri must protect their family from new threats in the oceans of Pandora.",
                Rating = "PG-13",
                Duration = "3h 12m"
            });

            movies.Add(new Movie
            {
                Title = "The Super Mario Bros. Movie",
                ImagePath = "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
                Description = "Mario and Luigi embark on an adventure to save the Mushroom Kingdom.",
                Rating = "PG",
                Duration = "1h 32m"
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

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
