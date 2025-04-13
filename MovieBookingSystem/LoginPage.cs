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
        public LoginPage()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=ASHLEY\\SQLEXPRESS;Initial Catalog=MovieBookingDB;Integrated Security=True";
        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO UsersTable (UserID, Username, Email, UserPassword) VALUES ('"
                 + Convert.ToInt32(textBox1.Text) + "', '"
                 + textBox2.Text + "', '"
                 + textBox3.Text + "', '"
                 + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login Successfully");
            }
        }
    }
}
