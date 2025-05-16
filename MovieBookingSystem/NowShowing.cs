using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Reflection.Emit;


namespace MovieBookingSystem
{
    public partial class NowShowing : Form
    {
        public NowShowing()
        {
            InitializeComponent();
        }

        private async void NowShowing_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize WebView2: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
                guna2CircleButton1.Visible = false;

                string html = @"
        <!DOCTYPE html>
        <html>
        <head>
            <meta http-equiv='X-UA-Compatible' content='IE=edge'>
            <style>
                html, body {
                    margin: 0;
                    padding: 0;
                    height: 100%;
                    overflow: hidden;
                    background-color: black;
                }
                iframe {
                    border: none;
                    width: 100%;
                    height: 100%;
                }
            </style>
        </head>
        <body>
            <iframe src='https://www.youtube.com/embed/UWMzKXsY9A4?autoplay=1&fs=1'
                    allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; fullscreen'
                    allowfullscreen>
            </iframe>
        </body>
        </html>";
                webView21.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading video: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
