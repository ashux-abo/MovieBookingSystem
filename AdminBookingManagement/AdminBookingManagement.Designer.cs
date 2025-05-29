namespace AdminBookingManagement
{
    partial class AdminBookingManagement
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 31, 32);
            panel1.Location = new Point(-12, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 555);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 31, 32);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(115, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 506);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(107, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 151);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AdminBookingManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 20);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminBookingManagement";
            Size = new Size(900, 534);
            Load += AdminBookingManagement_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
