using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel1.Location = new Point(this.Width, 40); 
            guna2Panel1.Visible = true;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {


        }
        private bool isSideBarExpanded = false; 
        private const int SidebarWidth = 200; 


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timeSideBar.Interval = 10;
            timeSideBar.Start(); 

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void timeSideBar_Tick(object sender, EventArgs e)
        {
            int step = 20; 
            if (isSideBarExpanded)
            {
                guna2Panel1.Location = new Point(guna2Panel1.Location.X + step, guna2Panel1.Location.Y);
                if (guna2Panel1.Location.X >= this.Width) 
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = false;
                }
            }
            else
            {
                guna2Panel1.Location = new Point(guna2Panel1.Location.X - step, guna2Panel1.Location.Y);
                if (guna2Panel1.Location.X <= this.Width - SidebarWidth) 
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = true;
                }

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string search;
            search = guna2TextBox1.Text;

           
        }

        private void guna2TextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                string search = guna2TextBox1.Text.Trim();
                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
