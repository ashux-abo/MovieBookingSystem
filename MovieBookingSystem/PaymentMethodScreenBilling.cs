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
namespace PaymentMethod
{
    public partial class PaymentMethodScreenBilling : Form
    {
        public PaymentMethodScreenBilling()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentMethodScreenBilling_Load(object sender, EventArgs e)
        {
            PopulateCityComboBox();
            PopulateStateComboBox();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
        private UserInfo savedUserInfo;
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (SaveTheUserInfo())
            {
                PaymentControl paymentControl = new PaymentControl();
                addUserControl(paymentControl);
            }

        }

        private bool SaveTheUserInfo()
        {
            string fullName = $"{Fname.Text} {Lname.Text}";

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(Eaddress.Text) ||
                string.IsNullOrWhiteSpace(Phone.Text) || string.IsNullOrWhiteSpace(City.Text) ||
                string.IsNullOrWhiteSpace(Address.Text) || string.IsNullOrWhiteSpace(ZipCode.Text) ||
                string.IsNullOrWhiteSpace(State.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (!int.TryParse(Phone.Text, out int phone) || !int.TryParse(ZipCode.Text, out int zip))
            {
                MessageBox.Show("Phone and Zip Code must be numeric.");
                return false;
            }

            // Store the user info in static property
            UserInfo.CurrentUser = new UserInfo(fullName, Eaddress.Text, phone, City.Text, Address.Text, zip, State.Text);

            //DEBUG: Verify the data was saved
            MessageBox.Show($"User information saved successfully!\nName: {UserInfo.CurrentUser.FullName}\nEmail: {UserInfo.CurrentUser.Email}");
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void PopulateCityComboBox()
        {
            City.DropDownStyle = ComboBoxStyle.DropDown;
            List<string> city = new List<string>
            {
                "Manila", "Quezon City","CALABARZON", "Cebu City", "Davao City", "Zamboanga City", "Taguig City",
                "Pasig City", "Makati City", "Caloocan City", "Antipolo City", "Iloilo City", "Baguio City",
                "General Santos City", "San Juan City", "Mandaluyong City"
            };
            foreach (var item in city)
            {
                City.Items.Add(item);
            }
        }
        private void PopulateStateComboBox()
        {
            State.DropDownStyle = ComboBoxStyle.DropDown;
            List<string> state = new List<string>
        {
            "Afghanistan", "Armenia", "Azerbaijan", "Bahrain", "Bangladesh", "Bhutan", "Brunei",
            "Cambodia", "China", "Cyprus", "Georgia", "India", "Indonesia", "Iran", "Iraq", "Israel",
            "Japan", "Jordan", "Kazakhstan", "Kuwait", "Kyrgyzstan", "Laos", "Lebanon", "Malaysia",
            "Maldives", "Mongolia", "Myanmar", "Nepal", "North Korea", "Oman", "Pakistan", "Palestine",
            "Philippines", "Qatar", "Saudi Arabia", "Singapore", "South Korea", "Sri Lanka", "Syria",
            "Taiwan", "Tajikistan", "Thailand", "Timor-Leste", "Turkey", "Turkmenistan", "United Arab Emirates",
            "Uzbekistan", "Vietnam", "Yemen"
        };
            foreach (var item in state)
            {
                State.Items.Add(item);
            }
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


