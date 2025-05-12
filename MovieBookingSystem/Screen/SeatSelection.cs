using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MovieBookingSystem.Screen
{
    public partial class SeatSelection : UserControl
    {
        public SeatSelection()
        {
            InitializeComponent();
            SeatSelection_Load(this, EventArgs.Empty); // Call the load method to initialize the seats
        }
        private int row = 5;
        private int column = 10;

        private void SeatSelection_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var seatButton = new Guna.UI2.WinForms.Guna2Button();
                    seatButton.Size = new Size(50, 50);
                    seatButton.Location = new Point(j * 60, i * 60);
                    seatButton.Text = $"{(char)('A' + i)}{j + 1}"; // Seat label (e.g., A1, A2, ...)
                  
                   
                }
            }
        }
    }
}
