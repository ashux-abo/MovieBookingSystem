using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingSystem.Control.AdminControl
{
    public partial class AddMovie : UserControl
    {
        private bool isImageImported = false;

        public AddMovie()
        {
            InitializeComponent();

            movieIDtxt.KeyPress += OnlyAllowNumbers;
            pricetxt.KeyPress += OnlyAllowNumbers;
            capacitytxt.KeyPress += OnlyAllowNumbers;
        }
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key
            }
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
            // Validate input fields including image check
            if (string.IsNullOrWhiteSpace(movieIDtxt.Text) ||
                string.IsNullOrWhiteSpace(movieNametxt.Text) ||
                genretxt.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(pricetxt.Text) ||
                string.IsNullOrWhiteSpace(capacitytxt.Text) ||
                PictureBox1.Image == null)
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }

            if (int.TryParse(capacitytxt.Text, out int capacityValue))
            {
                if (capacityValue > 100)
                {
                    MessageBox.Show("Capacity cannot exceed 100.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid number in Capacity.");
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
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Movie?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (guna2DataGridView2.SelectedRows.Count > 0)
                {
                    // Loop backwards in case multiple rows are selected
                    for (int i = guna2DataGridView2.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.SelectedRows[i].Index);
                    }

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear all text fields
                movieIDtxt.Clear();
                movieNametxt.Clear();
                pricetxt.Clear();
                capacitytxt.Clear();
                genretxt.SelectedIndex = -1;

                // Clear the DataGridView rows
                guna2DataGridView2.Rows.Clear();

                // Optionally clear image and reset image tracking
                guna2PictureBox1.Image = null;
                isImageImported = false;
            }
            // If "No" is clicked, do nothing
        }
        private void ClearFields()
        {
            PictureBox1.Image = null; // Clear the PictureBox image
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
                    PictureBox1.ImageLocation = openFileDialog.FileName;
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
