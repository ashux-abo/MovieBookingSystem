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
        }
    }
}
