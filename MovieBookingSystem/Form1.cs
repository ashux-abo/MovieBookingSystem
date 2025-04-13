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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            userControl11.Show();
            userControl21.Hide();
            UpdateButtonColor(button1);
        }
        Button selectedButton = null;
        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            UpdateButtonColor(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Show();
            userControl11.BringToFront();
            button1.BackColor = Color.Yellow;
            UpdateButtonColor(button1);
        }
        private void UpdateButtonColor(Button button)
        {
            
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.LightGray; 
            }

           
            selectedButton = button;
            button.BackColor = Color.Yellow; 
        }

    }
}
