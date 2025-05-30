using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();


            this.Load += AdminDashboard_Load;


            txtGenre.Size = new Size(200, 30);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            if (guna2DataGridView1.Columns.Count == 0)
            {
                guna2DataGridView1.Columns.Add("MovieID", "Movie ID");
                guna2DataGridView1.Columns.Add("MovieName", "Movie Name");
                guna2DataGridView1.Columns.Add("Genre", "Genre");
                guna2DataGridView1.Columns.Add("Price", "Price");
                guna2DataGridView1.Columns.Add("Capacity", "Capacity");
            }


            if (txtGenre.Items.Count == 0)
            {
                txtGenre.Items.AddRange(new object[]
                {
                    "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Romance"
                });

                txtGenre.SelectedIndex = 0;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtMovieID.Text) ||
                string.IsNullOrWhiteSpace(txtMovieName.Text) ||
                txtGenre.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            // Add row to DataGridView
            guna2DataGridView1.Rows.Add(
                txtMovieID.Text,
                txtMovieName.Text,
                txtGenre.SelectedItem.ToString(),
                txtPrice.Text,
                txtCapacity.Text
            );

            
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null)
            {
                guna2DataGridView1.CurrentRow.Cells[0].Value = txtMovieID.Text;
                guna2DataGridView1.CurrentRow.Cells[1].Value = txtMovieName.Text;
                guna2DataGridView1.CurrentRow.Cells[2].Value = txtGenre.SelectedItem?.ToString();
                guna2DataGridView1.CurrentRow.Cells[3].Value = txtPrice.Text;
                guna2DataGridView1.CurrentRow.Cells[4].Value = txtCapacity.Text;

                
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Movie","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.OK) 
            {

                if (guna2DataGridView1.SelectedRows.Count > 0 )
                {
                    foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows) 
                    { 
                        guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.CurrentRow.Index);

                    ClearFields(); 
                    
                    }
                   

                }

            }
            
        }

        private void ClearFields()
        {
            guna2PictureBox1.Clear();
            txtMovieID.Clear();
            txtMovieName.Clear();
            txtGenre.SelectedIndex = -1;
            txtPrice.Clear();
            txtCapacity.Clear();
        }

        private void txtGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGenre.SelectedItem != null)
            {
                string selectedGenre = txtGenre.SelectedItem.ToString();
                // Optional: MessageBox.Show("Selected: " + selectedGenre);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No special logic needed unless you want cell-specific actions
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            // Optional label logic
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom painting
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Photo";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the image from the selected file path
                    guna2PictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Optional: Resize the image to fit the PictureBox
                    guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}