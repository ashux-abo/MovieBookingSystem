using System.Windows.Forms;
using System.Drawing;
namespace MovieBookingSystem
{
    partial class BookingTicketPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchMovies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.movieList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearSelectedMovie = new System.Windows.Forms.Button();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.movieTitle = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.moviePrice = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.searchMovies);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.movieList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 523);
            this.panel1.TabIndex = 0;
            // 
            // searchMovies
            // 
            this.searchMovies.BorderRadius = 15;
            this.searchMovies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMovies.DefaultText = "";
            this.searchMovies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchMovies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchMovies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchMovies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchMovies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchMovies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchMovies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchMovies.Location = new System.Drawing.Point(10, 32);
            this.searchMovies.Name = "searchMovies";
            this.searchMovies.PlaceholderText = "Search Movies";
            this.searchMovies.SelectedText = "";
            this.searchMovies.Size = new System.Drawing.Size(346, 36);
            this.searchMovies.TabIndex = 15;
            this.searchMovies.TextChanged += new System.EventHandler(this.searchMovies_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Available Movies :";
            // 
            // movieList
            // 
            this.movieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Duration,
            this.Rated});
            this.movieList.Location = new System.Drawing.Point(10, 74);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(346, 433);
            this.movieList.TabIndex = 5;
            this.movieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieList_CellClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Rated
            // 
            this.Rated.HeaderText = "Rated";
            this.Rated.Name = "Rated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.clearSelectedMovie);
            this.panel2.Controls.Add(this.moviePoster);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.movieTitle);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.moviePrice);
            this.panel2.Controls.Add(this.movieGenre);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(396, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 198);
            this.panel2.TabIndex = 1;
            // 
            // clearSelectedMovie
            // 
            this.clearSelectedMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearSelectedMovie.FlatAppearance.BorderSize = 0;
            this.clearSelectedMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectedMovie.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.clearSelectedMovie.ForeColor = System.Drawing.Color.White;
            this.clearSelectedMovie.Location = new System.Drawing.Point(471, 157);
            this.clearSelectedMovie.Name = "clearSelectedMovie";
            this.clearSelectedMovie.Size = new System.Drawing.Size(71, 25);
            this.clearSelectedMovie.TabIndex = 37;
            this.clearSelectedMovie.Text = " CLEAR";
            this.clearSelectedMovie.UseVisualStyleBackColor = false;
            this.clearSelectedMovie.Click += new System.EventHandler(this.clearSelectedMovie_Click);
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(25, 29);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(117, 153);
            this.moviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviePoster.TabIndex = 36;
            this.moviePoster.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(363, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 25);
            this.button7.TabIndex = 34;
            this.button7.Text = "SELECT MOVIE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Poppins", 9F);
            this.movieTitle.ForeColor = System.Drawing.Color.White;
            this.movieTitle.Location = new System.Drawing.Point(287, 33);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(0, 22);
            this.movieTitle.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label24.Location = new System.Drawing.Point(187, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 22);
            this.label24.TabIndex = 25;
            this.label24.Text = "Movie Name :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(230, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 22);
            this.label25.TabIndex = 26;
            this.label25.Text = "Genre :";
            // 
            // moviePrice
            // 
            this.moviePrice.AutoSize = true;
            this.moviePrice.Font = new System.Drawing.Font("Poppins", 9F);
            this.moviePrice.ForeColor = System.Drawing.Color.White;
            this.moviePrice.Location = new System.Drawing.Point(287, 77);
            this.moviePrice.Name = "moviePrice";
            this.moviePrice.Size = new System.Drawing.Size(0, 22);
            this.moviePrice.TabIndex = 30;
            // 
            // movieGenre
            // 
            this.movieGenre.AutoSize = true;
            this.movieGenre.Font = new System.Drawing.Font("Poppins", 9F);
            this.movieGenre.ForeColor = System.Drawing.Color.White;
            this.movieGenre.Location = new System.Drawing.Point(287, 55);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(0, 22);
            this.movieGenre.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label16.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(237, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 22);
            this.label16.TabIndex = 17;
            this.label16.Text = "Price :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.displayPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.payment);
            this.panel3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(396, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 309);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(387, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "SELECT SEATS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(126, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // displayPrice
            // 
            this.displayPrice.AutoSize = true;
            this.displayPrice.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold);
            this.displayPrice.Location = new System.Drawing.Point(127, 246);
            this.displayPrice.Name = "displayPrice";
            this.displayPrice.Size = new System.Drawing.Size(55, 23);
            this.displayPrice.TabIndex = 51;
            this.displayPrice.Text = "label2";
            this.displayPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(31, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Total Price :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(471, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 25);
            this.button5.TabIndex = 49;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(387, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 25);
            this.button4.TabIndex = 48;
            this.button4.Text = "RECEIPT";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(387, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 32);
            this.button3.TabIndex = 42;
            this.button3.Text = "BUY";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label14.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(25, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 22);
            this.label14.TabIndex = 44;
            this.label14.Text = "Available Time:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(25, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 27);
            this.comboBox2.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label18.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(48, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 47;
            this.label18.Text = "Change :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label17.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(25, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 22);
            this.label17.TabIndex = 46;
            this.label17.Text = "Payment Amount :";
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(25, 56);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(157, 24);
            this.payment.TabIndex = 45;
            // 
            // BookingTicketPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BookingTicketPage";
            this.Size = new System.Drawing.Size(986, 562);
            this.Load += new System.EventHandler(this.BookingTicketPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private DataGridView movieList;
        private Label label12;
        private Label label16;
        private Button button7;
        private Label movieTitle;
        private Label label24;
        private Label label25;
        private Label moviePrice;
        private Label movieGenre;
        private PictureBox moviePoster;
        private Panel panel3;
        private Label label4;
        private Label displayPrice;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label14;
        private ComboBox comboBox2;
        private Label label18;
        private Label label17;
        private TextBox payment;
        private Guna.UI2.WinForms.Guna2TextBox searchMovies;
        private Button button1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Rated;
        private Button clearSelectedMovie;
    }
}
