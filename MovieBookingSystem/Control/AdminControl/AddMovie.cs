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

namespace MovieBookingSystem.Control.AdminControl
{
    public partial class AddMovie : UserControl
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            if (guna2DataGridView2.Columns.Count == 0)
            {
                guna2DataGridView2.Columns.Add("MovieID", "Movie ID");
                guna2DataGridView2.Columns.Add("MovieName", "Movie Name");
                guna2DataGridView2.Columns.Add("Genre", "Genre");
                guna2DataGridView2.Columns.Add("Price", "Price");
                guna2DataGridView2.Columns.Add("Capacity", "Capacity");
            }


            if (genretxt.Items.Count == 0)
            {
                genretxt.Items.AddRange(new object[]
                {
                    "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Romance"
                });

                genretxt.SelectedIndex = 0;
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(movieIDtxt.Text) ||
               string.IsNullOrWhiteSpace(movieNametxt.Text) ||
               genretxt.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(pricetxt.Text) ||
               string.IsNullOrWhiteSpace(capacitytxt.Text))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            // Add row to DataGridView
            guna2DataGridView2.Rows.Add(
                movieIDtxt.Text,
                movieNametxt.Text,
                genretxt.SelectedItem.ToString(),
                pricetxt.Text,
                capacitytxt.Text
            );


            ClearFields();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.CurrentRow != null)
            {
                guna2DataGridView2.CurrentRow.Cells[0].Value = movieIDtxt.Text;
                guna2DataGridView2.CurrentRow.Cells[1].Value = movieNametxt.Text;
                guna2DataGridView2.CurrentRow.Cells[2].Value = genretxt.SelectedItem?.ToString();
                guna2DataGridView2.CurrentRow.Cells[3].Value = pricetxt.Text;
                guna2DataGridView2.CurrentRow.Cells[4].Value = capacitytxt.Text;


                ClearFields();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Movie", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                if (guna2DataGridView2.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in guna2DataGridView2.SelectedRows)
                    {
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.CurrentRow.Index);

                        ClearFields();

                    }


                }

            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            /*   guna2PictureBox1.Clear();*/
            movieIDtxt.Clear();
            movieNametxt.Clear();
            genretxt.SelectedIndex = -1;
            pricetxt.Clear();
            capacitytxt.Clear();
        }

        private void genretxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genretxt.SelectedItem != null)
            {
                string selectedGenre = genretxt.SelectedItem.ToString();
                // Optional: MessageBox.Show("Selected: " + selectedGenre);
            }
        }

        private void importBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Photo";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the image from the selected file path
                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Optional: Resize the image to fit the PictureBox
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
