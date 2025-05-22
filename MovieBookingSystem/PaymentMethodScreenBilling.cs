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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            PaymentControl paymentControl = new PaymentControl();
            addUserControl(paymentControl);

            transferData summaryControl = new transferData();
            

            
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
    }
}

public class UserInfo
{

    private string FullName;
    private string Email;
    private int Phone;
    private string City;
    private string Address;
    private int Zip;
    private string Country;

    public UserInfo()
    {

    }
}
