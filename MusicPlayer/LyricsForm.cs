using MusicPlayer.Classes;
using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class LyricsForm : Form
    {
        private readonly Song song;

        public LyricsForm(string path)
        {
            InitializeComponent();

            this.song = new Song(path, false);
        }

        private void LyricsForm_Load(object sender, EventArgs e)
        {
            RichTextBoxLyrics.Text = song.lyrics;
            this.Text = song.artist + " - " + song.title + " :Lyrics:";

            RichTextBoxLyrics.SelectAll();
            RichTextBoxLyrics.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
