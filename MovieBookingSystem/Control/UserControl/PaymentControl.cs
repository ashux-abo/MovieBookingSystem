using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSystem.Model; 

namespace PaymentMethod
{
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            //testing
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void PaymentControl_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PaymentMethodScreenBilling paymentMethodScreen = new PaymentMethodScreenBilling();
            paymentMethodScreen.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (UserInfo.CurrentUser != null)
            {
                MessageBox.Show($"User info found!\nName: {UserInfo.CurrentUser.FullName}\nEmail: {UserInfo.CurrentUser.Email}");
                SummaryControl summaryControl = new SummaryControl(UserInfo.CurrentUser);
                addUserControl(summaryControl);
            }
            else
            {
                MessageBox.Show("No user information found. Please fill in your details first.");

           
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close(); 
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
