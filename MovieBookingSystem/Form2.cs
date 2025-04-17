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
    public partial class Form2 : Form
    {
        private Timer timer;
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter.jpeg",
           
        };
        public Form2()
        {
            InitializeComponent();
            CenterPanel(panel2); // Center the panel on form load
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.ImageLocation = imagePaths[currentImageIndex]; // Set the initial image


            timer = new Timer
            {
                Interval = 5000 // 5 seconds
            };
            timer.Tick += (sender, e) =>
            {
                // Switch the image
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
                guna2PictureBox1.ImageLocation = imagePaths[currentImageIndex];
            };
            timer.Start();

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(746, 504); // Fixed size
        }

        // Block system resizing commands
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x112;
            const int SC_SIZE = 0xF000;

            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_SIZE)
            {
                return; 
            }
            base.WndProc(ref m);
        }

        private void CenterPanel(System.Windows.Forms.Panel panel)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            panel.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Movie Booking System";

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            this.Hide(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Successful!");
        }
    }
}
