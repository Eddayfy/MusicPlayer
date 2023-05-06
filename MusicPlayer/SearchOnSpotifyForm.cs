using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SearchOnSpotifyForm : Form
    {
        private SpotifyWebAPI spotify;
        public FullTrack track;

        public SearchOnSpotifyForm(string searchValue)
        {
            InitializeComponent();

            this.SearchTextBox.Text = searchValue;
        }

        private void SearchOnSpotifyForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.AccessToken) && String.IsNullOrWhiteSpace(Properties.Settings.Default.TokenType))
            {
                if (new CredentialsAuthForm() { Icon = this.Icon }.ShowDialog() != DialogResult.OK)
                    this.Close();
            }

            spotify = new SpotifyWebAPI()
            {
                AccessToken = Properties.Settings.Default.AccessToken,
                TokenType = Properties.Settings.Default.TokenType
            };
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string query = SearchTextBox.Text;

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var result = spotify.SearchItems(query, SearchType.Track, 8).Tracks.Items;
                    FlowLayoutPanelSong.Controls.Clear();

                    foreach (var item in result)
                    {
                        string id = item.Id;
                        string name = item.Name;
                        string artists = String.Join(",", from artist in item.Artists select artist.Name);
                        Bitmap cover = null;

                        if (item.Album.Images.Count > 0)
                            cover = GetImage(item.Album.Images[0].Url);

                        var song_card = CreateSongCard(id, cover, name, artists);

                        FlowLayoutPanelSong.Controls.Add(song_card);
                    }
                }
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);

                var result = MessageBox.Show("It looks like an error has been alerted, maybe the token is expired.\nDo you want to generate a new one?", "The token may have expired.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (new CredentialsAuthForm() { Icon = this.Icon }.ShowDialog() == DialogResult.OK)
                    {
                        spotify = new SpotifyWebAPI()
                        {
                            AccessToken = Properties.Settings.Default.AccessToken,
                            TokenType = Properties.Settings.Default.TokenType
                        };
                    }
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Panel CreateSongCard(string Id, Bitmap Cover, string Title, string Artist)
        {
            Panel SongContainerPanel = new Panel()
            {
                BackColor = Color.FromArgb(18, 18, 18),
                Size = new Size(194, 194)
            };
            PictureBox SongCover = new PictureBox()
            {
                Location = new Point(47, 3),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Cover
            };
            Label SongTitle = new Label()
            {
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(5, 106),
                Size = new Size(185, 38),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Text = Title
            };
            Label SongArtist = new Label()
            {
                ForeColor = Color.White,
                Location = new Point(23, 153),
                Size = new Size(148, 15),
                TextAlign = ContentAlignment.TopCenter,
                Text = Artist,
                AutoSize = false
            };
            Panel SongPanelSepar = new Panel()
            {
                BackColor = SystemColors.Control,
                Location = new Point(24, 147),
                Size = new Size(146, 2)
            };
            Button SongThisOneButton = new Button()
            {
                Location = new Point(47, 176),
                Size = new Size(100, 20),
                Text = "This One",
                UseVisualStyleBackColor = true,
                BackColor = Color.FromArgb(64, 64, 64),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Popup,
                ForeColor = Color.White,
                Tag = Id
            };
            SongThisOneButton.Click += ThisSongCard_Click;

            SongContainerPanel.Controls.Add(SongCover);
            SongContainerPanel.Controls.Add(SongTitle);
            SongContainerPanel.Controls.Add(SongArtist);
            SongContainerPanel.Controls.Add(SongPanelSepar);
            SongContainerPanel.Controls.Add(SongThisOneButton);

            return SongContainerPanel;
        }

        private void ThisSongCard_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string id = (sender as Button).Tag.ToString();

                track = spotify.GetTrack(id);

                this.DialogResult = DialogResult.OK;
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

        public Bitmap GetImage(string Url)
        {
            try
            {
                WebRequest request = WebRequest.Create(Url);
                Stream responseStream = request.GetResponse().GetResponseStream();
                return new Bitmap(responseStream);
            }
            catch (WebException WebExc)
            {
                var result = MessageBox.Show(WebExc.Message + "\nWould you like to try Get the image again??", "Web Exception!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                    return GetImage(Url);
                else
                    return null;
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString(), "===:Get Image:===");
                return null;
            }
        }

    }
}
