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
    public partial class MovieCard : UserControl
    {
        private string movieTitle;
        private string movieDescription;
        private string movieImage;

        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public string MovieDescription { get => movieDescription; set => movieDescription = value; }
        public string MovieImage { get => movieImage; set => movieImage = value; }

        public MovieCard()
        {
            InitializeComponent();
        }

        private void MovieCard_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
public class Movie
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }

    public Movie(string title, string description, string imagePath)
    {
        Title = title;
        Description = description;
        ImagePath = imagePath;
    }

}
