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

namespace MovieBookingSystem
{
    public partial class SeatSelection : Form
    {
        private string conString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True";
        private List<string> selectedSeats = new List<string>();
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ShowTime { get; set; }
        public SeatSelection(int movieId, string movieTitle, DateTime showTime)
        {
            InitializeComponent();
            MovieId = movieId;
            MovieTitle = movieTitle;
            ShowTime = showTime;
        }
        public SeatSelection(DateTime showTime)
        {
            InitializeComponent();
            ShowTime = showTime;
        }
        public SeatSelection()
        {
            InitializeComponent();
        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {
            this.Text = $"Select Seats - {MovieTitle}";
            GenerateSeats(11, 10);
        }

        private void GenerateSeats(int rows, int cols)
        {
            int seatWidth = 50, seatHeight = 50;
            List<string> reservedSeats = GetReservedSeats(MovieId, ShowTime);
            seatSelectionPanel.Controls.Clear();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button
                    {
                        Name = $"Seat_{row}_{col}",
                        Text = $"{(char)('A' + row)}{col + 1}",
                        Size = new Size(seatWidth, seatHeight),
                        Location = new Point(col * (seatWidth + 5), row * (seatHeight + 5)),
                        BackColor = reservedSeats.Contains($"{(char)('A' + row)}{col + 1}") ? Color.Gray : Color.LightGray,
                        Enabled = !reservedSeats.Contains($"{(char)('A' + row)}{col + 1}")
                    };
                    seatButton.Click += (s, e) =>
                    {
                        if (seatButton.BackColor == Color.Green)
                        {
                            seatButton.BackColor = Color.LightGray;
                            selectedSeats.Remove(seatButton.Text);
                        }
                        else if (seatButton.BackColor == Color.LightGray)
                        {
                            seatButton.BackColor = Color.Green;
                            selectedSeats.Add(seatButton.Text);
                        }
                    };
                    seatSelectionPanel.Controls.Add(seatButton);
                }
            }
        }
        private void btnSeat_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("No seats selected.");
                return;
            }

            foreach (string seat in selectedSeats)
            {
                SaveSeatToDatabase(seat, "Booked", MovieId, ShowTime);
            }

            MessageBox.Show($"Seats successfully booked for {MovieTitle}!");
            selectedSeats.Clear();
            GenerateSeats(11, 10);

        }
        private List<string> GetReservedSeats(int movieId, DateTime showTime)
        {
            List<string> reservedSeats = new List<string>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = @"SELECT seatNumber FROM SeatReservationTable 
                               WHERE seatStatus = 'Booked' 
                               AND movieId = @MovieId 
                               AND showTime = @ShowTime";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);
                    command.Parameters.AddWithValue("@ShowTime", showTime);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        reservedSeats.Add(reader["seatNumber"].ToString());
                    }
                }
            }
            return reservedSeats;
        }

        private void SaveSeatToDatabase(string seatNumber, string status, int movieId, DateTime showTime)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = @"INSERT INTO SeatReservationTable (seatNumber, seatStatus, movieId, showTime, bookingDate) 
                               VALUES (@SeatNumber, @Status, @MovieId, @ShowTime, @BookingDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeatNumber", seatNumber);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@MovieId", movieId);
                    command.Parameters.AddWithValue("@ShowTime", showTime);
                    command.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void seatSelectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
