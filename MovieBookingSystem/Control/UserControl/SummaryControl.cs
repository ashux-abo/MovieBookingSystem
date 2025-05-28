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
using MovieBookingSystem;
namespace PaymentMethod
{
    public partial class SummaryControl : UserControl
    {

        private UserInfo userInfo;
        private UserCardInfo userCardInfo;
        public SummaryControl(UserInfo userInfo,UserCardInfo userCardInfo)

        {
            InitializeComponent();
            this.userInfo = userInfo;
            this.userCardInfo = userCardInfo;
        }

        public SummaryControl()
        {
            InitializeComponent();
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            ShowSummaryCard();
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
            this.ParentForm.Close();
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


        }


        private void ShowSummaryCard() {

            UserCardInfo cardInfoToShow = userCardInfo ?? UserCardInfo.cardCurrentInfo;
            if (cardInfoToShow != null)
            {
                CardNameDetails.Text = cardInfoToShow.CardName ?? "";
                CardNumberDetails.Text = cardInfoToShow.CardNum.ToString();
                ExpDateDetails.Text = cardInfoToShow.ExpDate.ToString();

            }
            else
            {
                CardNameDetails.Text = "No card name provided";
                CardNumberDetails.Text = "No card number provided";
                ExpDateDetails.Text = "No expiration date provided";
            }


        }



        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
