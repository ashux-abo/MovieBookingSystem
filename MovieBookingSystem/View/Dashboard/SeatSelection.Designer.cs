namespace MovieBookingSystem
{
    partial class SeatSelection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.screenLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.seatSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cinemaScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.availableSeat = new System.Windows.Forms.Panel();
            this.yourSeat = new System.Windows.Forms.Panel();
            this.soldSeat = new System.Windows.Forms.Panel();
            this.availableLabel = new System.Windows.Forms.Label();
            this.yourSeatLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.btnSeat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.cinemaScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // screenLabel
            // 
            this.screenLabel.AutoSize = true;
            this.screenLabel.BackColor = System.Drawing.Color.Transparent;
            this.screenLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenLabel.ForeColor = System.Drawing.Color.Black;
            this.screenLabel.Location = new System.Drawing.Point(242, 12);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(60, 23);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "SCREEN";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 35);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(955, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // seatSelectionPanel
            // 
            this.seatSelectionPanel.Location = new System.Drawing.Point(76, 164);
            this.seatSelectionPanel.Name = "seatSelectionPanel";
            this.seatSelectionPanel.Size = new System.Drawing.Size(849, 329);
            this.seatSelectionPanel.TabIndex = 2;
            this.seatSelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seatSelectionPanel_Paint);
            // 
            // cinemaScreen
            // 
            this.cinemaScreen.BorderColor = System.Drawing.Color.DarkGray;
            this.cinemaScreen.BorderRadius = 15;
            this.cinemaScreen.BorderThickness = 1;
            this.cinemaScreen.Controls.Add(this.screenLabel);
            this.cinemaScreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cinemaScreen.Location = new System.Drawing.Point(247, 43);
            this.cinemaScreen.Name = "cinemaScreen";
            this.cinemaScreen.Size = new System.Drawing.Size(517, 45);
            this.cinemaScreen.TabIndex = 3;
            // 
            // availableSeat
            // 
            this.availableSeat.BackColor = System.Drawing.Color.LightGray;
            this.availableSeat.Location = new System.Drawing.Point(76, 122);
            this.availableSeat.Name = "availableSeat";
            this.availableSeat.Size = new System.Drawing.Size(30, 30);
            this.availableSeat.TabIndex = 4;
            // 
            // yourSeat
            // 
            this.yourSeat.BackColor = System.Drawing.Color.Green;
            this.yourSeat.Location = new System.Drawing.Point(177, 122);
            this.yourSeat.Name = "yourSeat";
            this.yourSeat.Size = new System.Drawing.Size(30, 30);
            this.yourSeat.TabIndex = 5;
            // 
            // soldSeat
            // 
            this.soldSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soldSeat.Location = new System.Drawing.Point(279, 122);
            this.soldSeat.Name = "soldSeat";
            this.soldSeat.Size = new System.Drawing.Size(30, 30);
            this.soldSeat.TabIndex = 5;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.Color.White;
            this.availableLabel.Location = new System.Drawing.Point(112, 122);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(59, 19);
            this.availableLabel.TabIndex = 6;
            this.availableLabel.Text = "available";
            // 
            // yourSeatLabel
            // 
            this.yourSeatLabel.AutoSize = true;
            this.yourSeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourSeatLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSeatLabel.ForeColor = System.Drawing.Color.White;
            this.yourSeatLabel.Location = new System.Drawing.Point(213, 122);
            this.yourSeatLabel.Name = "yourSeatLabel";
            this.yourSeatLabel.Size = new System.Drawing.Size(60, 19);
            this.yourSeatLabel.TabIndex = 7;
            this.yourSeatLabel.Text = "your seat";
            // 
            // soldLabel
            // 
            this.soldLabel.AutoSize = true;
            this.soldLabel.BackColor = System.Drawing.Color.Transparent;
            this.soldLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldLabel.ForeColor = System.Drawing.Color.White;
            this.soldLabel.Location = new System.Drawing.Point(315, 122);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(32, 19);
            this.soldLabel.TabIndex = 8;
            this.soldLabel.Text = "sold";
            // 
            // btnSeat
            // 
            this.btnSeat.BorderRadius = 20;
            this.btnSeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeat.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnSeat.ForeColor = System.Drawing.Color.White;
            this.btnSeat.Location = new System.Drawing.Point(808, 43);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Size = new System.Drawing.Size(152, 45);
            this.btnSeat.TabIndex = 9;
            this.btnSeat.Text = "confirm my seat";
            this.btnSeat.Click += new System.EventHandler(this.btnSeat_Click);
            // 
            // SeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.btnSeat);
            this.Controls.Add(this.soldLabel);
            this.Controls.Add(this.yourSeatLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.soldSeat);
            this.Controls.Add(this.yourSeat);
            this.Controls.Add(this.availableSeat);
            this.Controls.Add(this.cinemaScreen);
            this.Controls.Add(this.seatSelectionPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatSelection";
            this.Load += new System.EventHandler(this.SeatSelection_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.cinemaScreen.ResumeLayout(false);
            this.cinemaScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label screenLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.FlowLayoutPanel seatSelectionPanel;
        private Guna.UI2.WinForms.Guna2Panel cinemaScreen;
        private System.Windows.Forms.Panel soldSeat;
        private System.Windows.Forms.Panel yourSeat;
        private System.Windows.Forms.Panel availableSeat;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.Label yourSeatLabel;
        private System.Windows.Forms.Label availableLabel;
        private Guna.UI2.WinForms.Guna2Button btnSeat;
    }
}