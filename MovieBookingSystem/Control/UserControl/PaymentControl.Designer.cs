using System.Drawing;
using System.Windows.Forms;

namespace PaymentMethod
{
    partial class PaymentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CreditDebitLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PaypalBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CreditDebitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.CVV = new Guna.UI2.WinForms.Guna2TextBox();
            this.CardNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.CardName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebitLogo)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExpDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.CreditDebitLogo);
            this.panel1.Controls.Add(this.PaypalBtn);
            this.panel1.Controls.Add(this.CreditDebitBtn);
            this.panel1.Controls.Add(this.guna2CheckBox1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Controls.Add(this.guna2HtmlLabel8);
            this.panel1.Controls.Add(this.guna2HtmlLabel7);
            this.panel1.Controls.Add(this.guna2HtmlLabel6);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.CVV);
            this.panel1.Controls.Add(this.CardNum);
            this.panel1.Controls.Add(this.CardName);
            this.panel1.Controls.Add(this.guna2Panel3);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExpDate
            // 
            this.ExpDate.BackColor = System.Drawing.Color.Transparent;
            this.ExpDate.BorderColor = System.Drawing.Color.White;
            this.ExpDate.BorderRadius = 15;
            this.ExpDate.BorderThickness = 1;
            this.ExpDate.Checked = true;
            this.ExpDate.FillColor = System.Drawing.Color.Black;
            this.ExpDate.Font = new System.Drawing.Font("Poppins", 9F);
            this.ExpDate.ForeColor = System.Drawing.Color.White;
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExpDate.Location = new System.Drawing.Point(51, 294);
            this.ExpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(327, 31);
            this.ExpDate.TabIndex = 94;
            this.ExpDate.UseTransparentBackground = true;
            this.ExpDate.Value = new System.DateTime(2025, 5, 28, 23, 6, 21, 186);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 93;
            this.label1.Text = "Payment Method";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BorderColor = System.Drawing.Color.White;
            this.ExitBtn.BorderRadius = 15;
            this.ExitBtn.BorderThickness = 1;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(12, 421);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(58, 30);
            this.ExitBtn.TabIndex = 92;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.guna2PictureBox2.ErrorImage = null;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = null;
            this.guna2PictureBox2.Location = new System.Drawing.Point(489, 158);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(33, 24);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 91;
            this.guna2PictureBox2.TabStop = false;
            // 
            // CreditDebitLogo
            // 
            this.CreditDebitLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.CreditDebitLogo.ErrorImage = null;
            this.CreditDebitLogo.FillColor = System.Drawing.Color.Transparent;
            this.CreditDebitLogo.Image = ((System.Drawing.Image)(resources.GetObject("CreditDebitLogo.Image")));
            this.CreditDebitLogo.ImageRotate = 0F;
            this.CreditDebitLogo.InitialImage = null;
            this.CreditDebitLogo.Location = new System.Drawing.Point(142, 162);
            this.CreditDebitLogo.Name = "CreditDebitLogo";
            this.CreditDebitLogo.Size = new System.Drawing.Size(28, 16);
            this.CreditDebitLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreditDebitLogo.TabIndex = 90;
            this.CreditDebitLogo.TabStop = false;
            // 
            // PaypalBtn
            // 
            this.PaypalBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaypalBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaypalBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaypalBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaypalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.PaypalBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaypalBtn.ForeColor = System.Drawing.Color.White;
            this.PaypalBtn.Location = new System.Drawing.Point(392, 155);
            this.PaypalBtn.Name = "PaypalBtn";
            this.PaypalBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaypalBtn.Size = new System.Drawing.Size(328, 31);
            this.PaypalBtn.TabIndex = 89;
            this.PaypalBtn.Text = "      Pay with Paypal";
            this.PaypalBtn.Click += new System.EventHandler(this.PaypalBtn_Click);
            // 
            // CreditDebitBtn
            // 
            this.CreditDebitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreditDebitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreditDebitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreditDebitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreditDebitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.CreditDebitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreditDebitBtn.ForeColor = System.Drawing.Color.White;
            this.CreditDebitBtn.Location = new System.Drawing.Point(70, 155);
            this.CreditDebitBtn.Name = "CreditDebitBtn";
            this.CreditDebitBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreditDebitBtn.Size = new System.Drawing.Size(328, 31);
            this.CreditDebitBtn.TabIndex = 88;
            this.CreditDebitBtn.Text = "       Credit or Debit Card";
            this.CreditDebitBtn.Click += new System.EventHandler(this.CreditDebitBtn_Click);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox1.Location = new System.Drawing.Point(50, 339);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(278, 23);
            this.guna2CheckBox1.TabIndex = 87;
            this.guna2CheckBox1.Text = "Save my payment method for future payment";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(431, 384);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(106, 29);
            this.guna2Button2.TabIndex = 86;
            this.guna2Button2.Text = "Back";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(393, 268);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(31, 25);
            this.guna2HtmlLabel9.TabIndex = 85;
            this.guna2HtmlLabel9.Text = "CVV";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(51, 268);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(104, 25);
            this.guna2HtmlLabel8.TabIndex = 84;
            this.guna2HtmlLabel8.Text = "Expiration Date";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(393, 206);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(94, 25);
            this.guna2HtmlLabel7.TabIndex = 83;
            this.guna2HtmlLabel7.Text = "Card Number";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(51, 206);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(102, 25);
            this.guna2HtmlLabel6.TabIndex = 82;
            this.guna2HtmlLabel6.Text = "Name On Card ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(542, 384);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(178, 29);
            this.guna2Button1.TabIndex = 81;
            this.guna2Button1.Text = "Proceed To Summary";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // CVV
            // 
            this.CVV.BorderRadius = 15;
            this.CVV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CVV.DefaultText = "";
            this.CVV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CVV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CVV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CVV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CVV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.CVV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CVV.Font = new System.Drawing.Font("Poppins", 9F);
            this.CVV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CVV.Location = new System.Drawing.Point(392, 294);
            this.CVV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CVV.Name = "CVV";
            this.CVV.PlaceholderText = "";
            this.CVV.SelectedText = "";
            this.CVV.Size = new System.Drawing.Size(328, 31);
            this.CVV.TabIndex = 80;
            this.CVV.TextChanged += new System.EventHandler(this.CVV_TextChanged);
            // 
            // CardNum
            // 
            this.CardNum.BorderRadius = 15;
            this.CardNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNum.DefaultText = "";
            this.CardNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CardNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CardNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.CardNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNum.Font = new System.Drawing.Font("Poppins", 9F);
            this.CardNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNum.Location = new System.Drawing.Point(392, 232);
            this.CardNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardNum.Name = "CardNum";
            this.CardNum.PlaceholderText = "";
            this.CardNum.SelectedText = "";
            this.CardNum.Size = new System.Drawing.Size(328, 31);
            this.CardNum.TabIndex = 78;
            this.CardNum.TextChanged += new System.EventHandler(this.CardNum_TextChanged);
            // 
            // CardName
            // 
            this.CardName.BorderRadius = 15;
            this.CardName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardName.DefaultText = "";
            this.CardName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CardName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CardName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.CardName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardName.Font = new System.Drawing.Font("Poppins", 9F);
            this.CardName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardName.Location = new System.Drawing.Point(50, 232);
            this.CardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CardName.Name = "CardName";
            this.CardName.PlaceholderText = "";
            this.CardName.SelectedText = "";
            this.CardName.Size = new System.Drawing.Size(328, 31);
            this.CardName.TabIndex = 77;
            this.CardName.TextChanged += new System.EventHandler(this.CardName_TextChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.guna2Panel3.Location = new System.Drawing.Point(494, 49);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(225, 42);
            this.guna2Panel3.TabIndex = 75;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(86, 10);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(67, 18);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Summary";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Location = new System.Drawing.Point(272, 49);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(225, 42);
            this.guna2Panel2.TabIndex = 74;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(87, 10);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(63, 18);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Payment";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Location = new System.Drawing.Point(50, 49);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(225, 42);
            this.guna2Panel1.TabIndex = 73;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(93, 10);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(46, 18);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Billing";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(92, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(46, 18);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Billing";
            // 
            // PaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel1);
            this.Name = "PaymentControl";
            this.Size = new System.Drawing.Size(771, 463);
            this.Load += new System.EventHandler(this.PaymentControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDebitLogo)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox CreditDebitLogo;
        private Guna.UI2.WinForms.Guna2Button PaypalBtn;
        private Guna.UI2.WinForms.Guna2Button CreditDebitBtn;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox CVV;
        private Guna.UI2.WinForms.Guna2TextBox CardNum;
        private Guna.UI2.WinForms.Guna2TextBox CardName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpDate;
    }
}
