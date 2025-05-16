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
    public partial class Form2 : Form
    {
        private Timer timer;
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
           
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
        private string conString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True";
        private void dataValidation(object sender, EventArgs e)
        {
            // check if the fields are empty or not
            if (string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(LastName.Text) || string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            } else
            {
                bool checkRegister = RegisterUser(FirstName.Text, LastName.Text, Email.Text, RegisterPassword.Text);    
            }
        }

        private bool RegisterUser(string firstName, string lastName, string email, string password)
        {
            //This will perform the data validation here
            if(firstName.Length >= 50 || lastName.Length >= 50 || email.Length >= 50 || password.Length > 50)
            {
                MessageBox.Show("Input exceeds maximum length."); //If the user input exceeds to the total length of 50 characters then it will show this message
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long."); //the password must be at least 8 characters long
                return false;
            }
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string checkQuery = "SELECT COUNT(*) FROM RegisterUser WHERE REmail = @Email";
                SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                checkCommand.Parameters.AddWithValue("@Email", email);
                if ((int)checkCommand.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                    return false;
                }
                    string insertQuery = "INSERT INTO RegisterUser (RFirstName, RLastName, REmail, RPassword)" +
                  "VALUES ('"
                  + FirstName.Text.ToString() + "', '"
                  + LastName.Text.ToString() + "', '"
                  + Email.Text.ToString() + "', '"
                  + RegisterPassword.Text.ToString() + "')";

                    SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful!");               
            } 
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            this.Hide(); 
        }
       


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataValidation(sender, e);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
