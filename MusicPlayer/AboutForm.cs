﻿using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkLabelAppGodName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/eddayfy");
        }
    }
}
