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
    public partial class MainPage : Form
    {
        private string[] imagePaths = new string[]
                {
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter.jpeg",
                };

        public MainPage()
        {

            InitializeComponent();
            /* foreach (var showImage in imagePaths)
             {
                 var pictureBox = new PictureBox();
                 pictureBox.Image = Image.FromFile(showImage);
                 pictureBox.Click += (s, e) => { Handle click event };
                 this.Controls.Add(pictureBox);
             }
     */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(-SidebarWidth, 40); // Set the initial location of the panel
            panel2.Visible = true; // Make the panel visible
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool isSideBarExpanded = false;
        private const int SidebarWidth = 200;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timeSideBar.Interval = 10;
            timeSideBar.Start();
        }

        private void timeSideBar_Tick(object sender, EventArgs e)
        {
            int step = 20;
            if (isSideBarExpanded)
            {
                panel2.Location = new Point(panel2.Location.X - step, panel2.Location.Y);
                if (panel2.Location.X <= -SidebarWidth)
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = false;
                }
            }
            else
            {
                panel2.Location = new Point(panel2.Location.X + step, panel2.Location.Y);
                if (panel2.Location.X >= 0)
                {
                    timeSideBar.Stop();
                    isSideBarExpanded = true;
                }
            }
        }
    }
}
