using MusicPlayer.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class EditForm : Form
    {
        public Song song;

        public EditForm(string path)
        {
            InitializeComponent();

            song = new Song(path, false);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            TextBoxGenre.AutoCompleteCustomSource.AddRange(TagLib.Genres.Audio);

            TextBoxTitle.Text = song.title;
            TextBoxArtists.Text = song.artist;
            TextBoxAlbum.Text = song.album;
            TextBoxTrack.Text = song.track;
            TextBoxTrackCount.Text = song.trackCount;
            TextBoxGenre.Text = song.genres;
            RichTextBoxLyrics.Text = song.lyrics;
            PictureBoxCover.Image = song.cover;
            TextBoxYear.Text = song.year;

            this.Text = song.artist + " - " + song.title + " :Edit:";
        }

        private void ButtonChooseCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Image Files|*.png; *.jpg *.jpeg | All files |*.*"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if (OFD.FileName.EndsWith(".png") || OFD.FileName.EndsWith(".jpg") || OFD.FileName.EndsWith(".jpeg"))
                {
                    PictureBoxCover.Image = new Bitmap(OFD.FileName);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TextBoxTitle.Text))
                    Song.SetTitle(song.path, TextBoxTitle.Text);

                if (!string.IsNullOrWhiteSpace(TextBoxArtists.Text))
                    Song.SetArtists(song.path, TextBoxArtists.Text);

                if (!string.IsNullOrWhiteSpace(TextBoxAlbum.Text))
                    Song.SetAlbum(song.path, TextBoxAlbum.Text);

                if (!string.IsNullOrWhiteSpace(RichTextBoxLyrics.Text))
                    Song.SetLyrics(song.path, RichTextBoxLyrics.Text);

                if (PictureBoxCover.Image != null)
                    Song.SetCover(song.path, new Bitmap(PictureBoxCover.Image));

                if (!string.IsNullOrWhiteSpace(TextBoxTrack.Text))
                    Song.SetTrack(song.path, TextBoxTrack.Text);

                if (!string.IsNullOrWhiteSpace(TextBoxTrackCount.Text))
                    Song.SetTrackCount(song.path, TextBoxTrackCount.Text);

                if (!string.IsNullOrWhiteSpace(TextBoxYear.Text))
                    Song.SetYear(song.path, TextBoxYear.Text);

                if (!string.IsNullOrWhiteSpace(TextBoxGenre.Text))
                    Song.SetGenre(song.path, TextBoxGenre.Text);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);
            }
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<string> titleItems = new List<string>();

                if (!string.IsNullOrWhiteSpace(TextBoxArtists.Text))
                    titleItems.Add(TextBoxArtists.Text);
                if (!string.IsNullOrWhiteSpace(TextBoxTitle.Text))
                    titleItems.Add(TextBoxTitle.Text);

                string searchValue = String.Join(" - ", titleItems);

                SearchOnSpotifyForm searchForm = new SearchOnSpotifyForm(searchValue) { Icon = this.Icon };

                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    TextBoxTitle.Text = searchForm.track.Name;
                    TextBoxArtists.Text = String.Join(",", from artist in searchForm.track.Artists select artist.Name);
                    TextBoxAlbum.Text = searchForm.track.Album.Name;
                    TextBoxTrack.Text = searchForm.track.TrackNumber.ToString();
                    TextBoxTrackCount.Text = searchForm.track.Album.TotalTracks.ToString();
                    TextBoxYear.Text = searchForm.track.Album.ReleaseDate;

                    if (searchForm.track.Album.Images.Count > 0)
                        PictureBoxCover.Image = searchForm.GetImage(searchForm.track.Album.Images[0].Url);

                    //if (!string.IsNullOrWhiteSpace(searchForm.song.lyrics))
                    //    RichTextBoxLyrics.Text = searchForm.song.lyrics;

                    MessageBox.Show("The auto tags has been added.", "The auto tags.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
