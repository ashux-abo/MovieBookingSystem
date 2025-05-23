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
        public SeatSelection()
        {
            InitializeComponent();
        }

        private void SeatSelection_Load(object sender, EventArgs e) //load the seat selection form
        {
            GenerateSeats(11, 10);
        }

        private void GenerateSeats(int rows, int cols) //generate the seats dynamically
        {
            int seatWidth = 50, seatHeight = 50; 
            List<string> reservedSeats = GetReservedSeats();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button
                    {
                        Name = $"Seat_{row}_{col}",
                        Text = $"{(char)('A' + row)}{col + 1}",
                        Size = new Size(seatWidth, seatHeight),
                        Location = new Point(col * (seatWidth + 5), row * (seatHeight + 5)), // inadjust yung margin space sa seat
                        BackColor = reservedSeats.Contains($"{(char)('A' + row)}{col + 1}") ? Color.Gray : Color.LightGray, // condition para malaman kung naka booked na
                        Enabled = !reservedSeats.Contains($"{(char)('A' + row)}{col + 1}") 
                    };

                    // Toggle seat selection color
                    seatButton.Click += (s, e) =>
                    {
                        if (seatButton.BackColor == Color.Green)
                        {
                            seatButton.BackColor = Color.Gray;
                            selectedSeats.Remove(seatButton.Text); // Remove unselected seat
                        }
                        else
                        {
                            seatButton.BackColor = Color.Green;
                            selectedSeats.Add(seatButton.Text); // Add selected seat
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
                SaveSeatToDatabase(seat, "Booked");
            }

            MessageBox.Show("Seats successfully booked!");
            selectedSeats.Clear(); // Clear selection after booking

        }
        private List<string> GetReservedSeats() //get the reserved seats from the database
        {
            List<string> reservedSeats = new List<string>();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT seatNumber FROM SeatReservationTable WHERE seatStatus = 'Booked'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        reservedSeats.Add(reader["seatNumber"].ToString());
                    }
                }
            }
            return reservedSeats;
        }


        private void SaveSeatToDatabase(string seatNumber, string status) //save the selected seat to the database
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO SeatReservationTable (seatNumber, seatStatus) VALUES (@SeatNumber, @Status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeatNumber", seatNumber);
                    command.Parameters.AddWithValue("@Status", status);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
