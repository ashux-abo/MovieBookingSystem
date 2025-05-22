using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMethod
{
    public partial class SummaryControl : UserControl
    {
        public SummaryControl()
        {
            InitializeComponent();
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            PaymentControl paymentControl = new PaymentControl();
            addUserControl(paymentControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Confirmed");
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
