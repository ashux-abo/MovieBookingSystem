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
using System.Security.Cryptography;

namespace MovieBookingSystem
{
    public partial class LoginPage : Form
    {
        private Timer imageTimer;
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\minecraftpost.png",
            "C:\\Users\\dulay\\source\\repos\\MovieBookingSystem\\MovieBookingSystem\\Resources\\spidermanposter1.jpeg",
        };

        // Use connection string from config file in production
        private readonly string connectionString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True;Connection Timeout=30;";

        public LoginPage()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            CenterPanel(panel2);
            InitializeImageSlideshow();
            PopulateRoles();

            // Set default selection
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 1; // Default to Customer
            }
        }

        private void InitializeImageSlideshow()
        {
            imageTimer = new Timer
            {
                Interval = 3000 // 3 seconds
            };
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
                if (guna2PictureBox1 != null && System.IO.File.Exists(imagePaths[currentImageIndex]))
                {
                    guna2PictureBox1.ImageLocation = imagePaths[currentImageIndex];
                }
            }
            catch (Exception ex)
            {
                // Log error in production
                System.Diagnostics.Debug.WriteLine($"Error changing image: {ex.Message}");
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Size = new Size(746, 504); // Fixed size
            CenterPanel(panel2); // Re-center panel when size changes
        }

        private void CenterPanel(System.Windows.Forms.Panel panel)
        {
            if (panel == null) return;

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            panel.Location = new Point((formWidth - panelWidth) / 2, (formHeight - panelHeight) / 2);
        }

        private void PopulateRoles()
        {
            comboBox1.Items.Clear();
            List<string> roles = new List<string> { "Admin", "Customer" };

            foreach (string role in roles)
            {
                comboBox1.Items.Add(role);
            }
        }

        private async Task<bool> LoginUserAsync(string email, string password)
        {
            if (!ValidateInput(email, password))
                return false;

            try
            {
                string selectedRole = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedRole))
                {
                    MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (selectedRole == "Admin")
                {
                    return await AuthenticateAdminAsync(email, password);
                }
                else if (selectedRole == "Customer")
                {
                    return await AuthenticateCustomerAsync(email, password);
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidateInput(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (email.Length > 50 || password.Length > 50)
            {
                MessageBox.Show("Input exceeds maximum length (50 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task<bool> AuthenticateAdminAsync(string email, string password)
        {
            if (email == "admin@gmail.com" && password == "admin123")
            {
                MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Close();

                return true;
            }
            else
            {
                MessageBox.Show("Invalid admin credentials.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> AuthenticateCustomerAsync(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string loginQuery = @"SELECT COUNT(*) FROM RegisterUser 
                                    WHERE REmail = @Email AND RPassword = @Password";

                using (SqlCommand command = new SqlCommand(loginQuery, connection))
                {
                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = email;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;

                    int userCount = (int)await command.ExecuteScalarAsync();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Customer Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        this.Close();

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {

            guna2Button1.Enabled = false;

            try
            {
                await LoginUserAsync(Email.Text.Trim(), LoginPassword.Text);
            }
            finally
            {
                guna2Button1.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Form2 registerPage = new Form2();
                registerPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening registration page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            // Clean up resources before closing
            imageTimer?.Stop();
            imageTimer?.Dispose();
            Application.Exit();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginPassword != null)
            {
                if (showPass.Checked)
                {
                    LoginPassword.UseSystemPasswordChar = false;
                    LoginPassword.PasswordChar = '\0';
                }
                else
                {
                    LoginPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SideTitle_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                imageTimer?.Stop();
                imageTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}