using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Reflection.Emit;


namespace NowShowing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
        }

        private async void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string videoUrl = "https://youtu.be/UWMzKXsY9A4";
            webView21.Source = new Uri(videoUrl);
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

        private void minecraftButton1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
