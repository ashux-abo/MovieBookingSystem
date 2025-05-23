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
    public partial class LoginPage : Form
    {
        private Timer timer;
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
        };
        public LoginPage()
        {
            InitializeComponent();
            CenterPanel(panel2); // Center the panel on form load
            timer = new Timer
            {
                Interval = 3000 //set it to 5 seconds
            };
            timer.Tick += (sender, e) =>
            {
                // Switch the image
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
                guna2PictureBox1.ImageLocation = imagePaths[currentImageIndex];
            };
            timer.Start();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Size = new Size(746, 504); // Fixed size
        }
        private void CenterPanel(System.Windows.Forms.Panel panel)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            panel.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);
        }
        private string conString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True";
        
        private bool LoginUser(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            if (email.Length >= 50 || password.Length > 50)
            {
                MessageBox.Show("Input exceeds maximum length.");
                return false;
            }
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string loginQuery = "SELECT COUNT(*) FROM RegisterUser WHERE REmail = @Email AND RPassword = @Password";
            SqlCommand sqlCommand = new SqlCommand(loginQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            if ((int)sqlCommand.ExecuteScalar() > 0)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide(); // Hide the current form
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginUser(Email.Text, LoginPassword.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registerPage = new Form2();
            registerPage.Show();
            this.Hide(); // Hide the current form
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
