using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSystem.Control.AdminControl;

namespace MovieBookingSystem
{
    public partial class AdminUI : Form
    {
        private string v1;
        private string v2;
        private string v;

        public AdminUI()
        {
            InitializeComponent();
        }

        public AdminUI(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public AdminUI(string v)
        {
            this.v = v;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
                Application.Exit(); 
            }
            else
            {         
                return;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void addUserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            user.Anchor = AnchorStyles.None;
            panel3.Controls.Clear();
            panel3.Controls.Add(user);
            user.BringToFront();
        }*/

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard Button Clicked");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            // Create an instance of the AddMovie user control
            AddMovie addMovieUC = new AddMovie
            {
                Dock = DockStyle.Fill // Optional: make it fill the container
            };

            // Add it to the panel
            panel3.Controls.Add(addMovieUC);


            MessageBox.Show("Booking Ticket Button Clicked");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Movie Button Clicked");
        }
    }
}
