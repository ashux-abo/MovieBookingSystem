using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaymentMethod;
using MovieBookingSystem.Model;
using System.Net.Mail;
namespace PaymentMethod
{
    public partial class SummaryControl : UserControl
    {

        private UserInfo userInfo;
        private UserCardInfo userCardInfo;
        public SummaryControl(UserInfo userInfo)

        {
            InitializeComponent();
            this.userInfo = userInfo;
        }

        public SummaryControl()
        {
            InitializeComponent();
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            ShowSummaryDetails();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void ShowSummaryDetails()
        {
            // First try to use the userInfo passed via constructor
            UserInfo infoToShow = userInfo ?? UserInfo.CurrentUser;

            if (infoToShow != null)
            {
                OwnerName.Text = infoToShow.FullName ?? "";
                SummaryAddress.Text = infoToShow.Address ?? "";
                SummaryPhone.Text = infoToShow.Phone.ToString();
                SummaryEmail.Text = infoToShow.Email ?? "";
            }
            else
            {
                // Handle case when no user info is available
                OwnerName.Text = "No name provided";
                SummaryAddress.Text = "No address provided";
                SummaryPhone.Text = "No phone provided";
                SummaryEmail.Text = "No email provided";
            }

            UserCardInfo cardInfoToShow = userCardInfo ?? UserCardInfo.cardCurrentInfo;
            /*if (cardInfoToShow != null) {
                CardName.Text = cardInfoToShow.CardName ?? "";
                CardNum.Text = cardInfoToShow.CardNumber.ToString();
                ExpDate.Text = cardInfoToShow.ExpirationDate.ToString();
                CVV.Text = cardInfoToShow.CVV.ToString();
            }
            else
            {
                // Handle case when no user card info is available
                CardName.Text = "No card name provided";
                CardNum.Text = "No card number provided";
                ExpDate.Text = "No expiration date provided";
                CVV.Text = "No CVV provided";

            }*/
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

    }
}
