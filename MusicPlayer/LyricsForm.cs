using System.Windows.Forms;
using System;

namespace MusicPlayer
{
    public partial class LyricsForm : Form
    {
        private string MusicPath;
        public LyricsForm()
        {
            InitializeComponent();
        }

        public LyricsForm(string MusicPath)
        {
            InitializeComponent();

            this.MusicPath = MusicPath;
        }

        private void LyricsForm_Load(object sender, EventArgs e)
        {
            RichTextBoxLyrics.Text = TagFile.Lyrics(MusicPath);
            this.Text = TagFile.Artist(MusicPath) + " - " + TagFile.Title(MusicPath) + " :Lyrics:";

            RichTextBoxLyrics.SelectAll();
            RichTextBoxLyrics.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            using (TagLib.File Track = TagLib.File.Create(MusicPath))
            {
                Track.Tag.Lyrics = RichTextBoxLyrics.Text;

                try
                {
                    Track.Save();
                    MessageBox.Show("The Lyrics saved!");

                    RichTextBoxLyrics.ReadOnly = true;
                    ButtonSave.Visible = false;
                    EditeLyricsCheckBox.Checked = false;
                }
                catch
                {
                    MessageBox.Show("The process cannot access the file, because it is being used by another process.");
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditeLyricsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditeLyricsCheckBox.Checked)
            {
                RichTextBoxLyrics.ReadOnly = false;
                ButtonSave.Visible = true;
            }
            else
                RichTextBoxLyrics.ReadOnly = true;
        }

        private void RichTextBoxLyrics_TextChanged(object sender, EventArgs e)
        {
            RichTextBoxLyrics.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
