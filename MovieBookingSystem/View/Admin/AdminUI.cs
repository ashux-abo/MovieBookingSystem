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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
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
                Application.Exit();
            }
            else
            {         
                return;
            }
        }
    }
}
