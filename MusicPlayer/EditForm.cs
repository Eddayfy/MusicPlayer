using SpotifyAPI.Web;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class EditForm : Form
    {
        private int CurrentPlayingMusicIndex;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int CurrentPlayingMusicIndex)
        {
            InitializeComponent();

            this.CurrentPlayingMusicIndex = CurrentPlayingMusicIndex;

            EditFormInitialise(CurrentPlayingMusicIndex);
        }

        private void EditFormInitialise(int Index)
        {
            string TrackPath = MusicPlayer_.Music[Index];

            TextBoxTitle.Text = TagFile.Title(TrackPath);
            this.Text = TextBoxTitle.Text;
            TextBoxAlbumArtist.Text = TagFile.Artist(TrackPath);
            TextBoxArtist.Text = TagFile.Artists(TrackPath);
            TextBoxAlbum.Text = TagFile.Album(TrackPath);
            TextBoxYear.Text = TagFile.Year(TrackPath);
            TextBoxTrack.Text = TagFile.Track(TrackPath);
            TextBoxTrackCount.Text = TagFile.TrackCount(TrackPath);
            TextBoxDisc.Text = TagFile.Disc(TrackPath);
            TextBoxDiscCount.Text = TagFile.DiscCount(TrackPath);
            TextBoxComposers.Text = TagFile.Composers(TrackPath);
            TextBoxGenre.Text = TagFile.Genre(TrackPath);
            TextBoxGrouping.Text = TagFile.Grouping(TrackPath);
            RichTextBoxLyrics.Text = TagFile.Lyrics(TrackPath);
            PictureBoxCover.Image = TagFile.Cover(TrackPath);
            PictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
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
            using (TagLib.File Track = TagLib.File.Create(MusicPlayer_.Music[CurrentPlayingMusicIndex]))
            {
                Track.Tag.Title = TextBoxTitle.Text;
                Track.Tag.AlbumArtists = new string[] { TextBoxArtist.Text };

                try
                {
                    Track.Tag.AlbumArtists = TextBoxAlbumArtist.Text.Trim(' ').Split(',');
                }
                catch
                {
                    MessageBox.Show("AlbumArtists");
                }

                Track.Tag.Album = TextBoxAlbum.Text;
                Track.Tag.Year = Convert.ToUInt32(TextBoxYear.Text);
                Track.Tag.Track = Convert.ToUInt32(TextBoxTrack.Text);
                Track.Tag.TrackCount = Convert.ToUInt32(TextBoxTrackCount.Text);
                Track.Tag.Disc = Convert.ToUInt32(TextBoxDisc.Text);
                Track.Tag.DiscCount = Convert.ToUInt32(TextBoxDiscCount.Text);

                try
                {
                    Track.Tag.Composers = TextBoxComposers.Text.Trim(' ').Split(',');
                }
                catch
                {
                    MessageBox.Show("Composers");
                }

                Track.Tag.Genres = new string[] { TextBoxGenre.Text };
                Track.Tag.Grouping = TextBoxGrouping.Text;
                Track.Tag.Lyrics = RichTextBoxLyrics.Text;

                Track.Tag.Pictures = new TagLib.IPicture[]
                {
                    new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(PictureBoxCover.Image, typeof(byte[]))))
                    {
                        Type = TagLib.PictureType.FrontCover,
                        Description = "Cover",
                        MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg
                    }
                };

                try
                {
                    Track.Save();
                    MessageBox.Show("The file saved!");
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

        private void ButtonPrevieus_Click(object sender, EventArgs e)
        {
            if (CurrentPlayingMusicIndex != 0)
                EditFormInitialise(--CurrentPlayingMusicIndex);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (CurrentPlayingMusicIndex != MusicPlayer_.Music.Count - 1)
                EditFormInitialise(++CurrentPlayingMusicIndex);
        }

        private void RadioButtonRTL_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonRTL.Checked)
                RichTextBoxLyrics.RightToLeft = RightToLeft.Yes;
        }

        private void RadioButtonLTR_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonLTR.Checked)
                RichTextBoxLyrics.RightToLeft = RightToLeft.No;
        }

        async Task AutoInitialize()
        {
            var spotify = new SpotifyClient("BQAEPqQZWD0hrH4DPS33Ixi6BTmdc9Q5jEYMLi1B-RNqT4ZcLj37SsHafiAwWZP_oE_r103C8jW5fs0HR0AHL5wtEt8eXazG6qVpvXHUwchUNA4K874OxVyt18a_xypyBjJNUOaOn_1-QRxZlITB5gD6H7KM8j97df1pb_G6flJXQI9a-fOIg6npXutYdaLPkiF8RtZCzL1WE3nIm0Nfv07pFOqXpMaF1bfELQxemerVT0bw0BSCYNwsr4ejdwTBzeQjgtndfXUGfYPgg5AZA_hNTID0LihllsQ");

            var track = await spotify.Tracks.Get("4eQfhof6xQ2H6XSkMTlLFS");

            TextBoxTitle.Text = track.Name;

            foreach (var artist in track.Artists)
                TextBoxAlbumArtist.Text += artist.Name + ", ";

            TextBoxAlbum.Text = track.Album.Name;

            using (WebClient wc = new WebClient())
            {
                using (Stream s = wc.OpenRead(track.Album.Images[0].Url))
                {
                    using (Bitmap bmp = new Bitmap(s))
                    {
                        PictureBoxCover.Image = new Bitmap(bmp, PictureBoxCover.Width, PictureBoxCover.Height);
                    }
                }
            }
        }

        private async void ButtonAuto_Click(object sender, EventArgs e)
        {
            await AutoInitialize();
        }
    }
}
