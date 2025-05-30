using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem.Model
{
    public class MovieDetails
    {
        public static MovieDetails movieCurrentInfo { get; set; }
        private string movieTitle;
        private string movieDescription;
        private string movieImage;
        private string movieGenre;
        private string movieDuration;
        private string moviePrice;

        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }
        public string MovieDescription { 
            get { return movieDescription; }
            set { movieDescription = value; }
        }
        public string MovieImage
        {
            get { return movieImage; }
            set { movieImage = value; }
        }
        public string MovieGenre
        {
            get { return movieGenre; }
            set { movieGenre = value; }
        }
        public string MovieDuration
        {
            get { return movieDuration; }
            set { movieDuration = value; }
        }
        public string MoviePrice
        {
            get { return moviePrice; }
            set { moviePrice = value; }
        }

        public int MovieId { get; internal set; }

        public MovieDetails()
        {
            //default constructor
        }

        public MovieDetails(string movieTitle, string movieDescription, string movieImage, string movieGenre, string movieDuration)
        {
            this.movieTitle = movieTitle;
            this.movieDescription = movieDescription;
            this.movieImage = movieImage;
            this.movieGenre = movieGenre;
            this.movieDuration = movieDuration;
        }
    }
}
