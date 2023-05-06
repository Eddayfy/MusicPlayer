using MusicPlayer.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private Song song;
        public static List<string> Musics;
        private List<string> AudioExtensions;
        private int CurrentMusicIndex;
        private MusicState MusicState;
        private ShuffleState ShuffleState;
        private LoopState LoopState;
        private SortedMethode LastSortedMethode;

        //  =================== ======================= \\

        //private AudioFileReader AudioFileReader;
        //private bool IsFileGenerateException;
        //private WaveOutEvent WaveOutEvent;
        //private Random RandomValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            Musics = new List<string>();
            MusicState = MusicState.Pause;
            ShuffleState = ShuffleState.Off;
            LoopState = LoopState.Off;
            CurrentMusicIndex = 0;
            LastSortedMethode = SortedMethode.Title;

            AudioExtensions = new List<string>()
            {
                ".mp3", ".m4a", ".ogg", ".wav", ".3gp", ".flac", ".m4b", ".m4p", ".mpeg", ".mp4"
            };

            PlaybackBarControl.ChangedProgressPanel.MouseMove += ChangedProgressPanel_MouseMove;
        }

        private void OpenFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string audioFilter = "Audio Files|";

            foreach (string ext in AudioExtensions)
                audioFilter += ("*" + ext + "; ");

            audioFilter += "| All files |*.*";

            OpenFileDialog OFD = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "Audio Files|*.mp3; *.m4a; *.ogg; *.wav; *.3gp; *.flac; *.m4b; *.m4p; *.mpeg; | All files |*.*"
                Filter = audioFilter
            };

            if (OFD.ShowDialog() == DialogResult.OK)
                AddItemsInListToTheMainList(OFD.FileNames.ToList());
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                var AllFilesPath = Directory.EnumerateFiles(FBD.SelectedPath, "*.*", SearchOption.AllDirectories);

                List<string> OnlyAudioFiles = new List<string>();
                foreach (var FilePath in AllFilesPath)
                    if (FileIsAudio(FilePath))
                        OnlyAudioFiles.Add(FilePath);

                AddItemsInListToTheMainList(OnlyAudioFiles);
            }
        }

        private void AddMusicToFlowLayoutPanel(string MusicPath)
        {
            MusicPanel MusicPanel = new MusicPanel(MusicPath);
            MusicPanel.DoubleClick += MusicPanel_DoubleClick;
            MusicPanel.Click += MusicPanel_Click;
            MusicPanel.MouseClick += MusicPanel_MouseClick;
            FlowLayoutPanelMusic.Controls.Add(MusicPanel);
        }

        private void MusicPanel_DoubleClick(object sender, EventArgs e)
        {
            MusicPanel ClickedMusic = sender as MusicPanel;

            for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
            {
                if (FlowLayoutPanelMusic.Controls[i] == ClickedMusic)
                {
                    CurrentMusicIndex = i;
                    MusicInitialize(ClickedMusic.MusicPath);
                }

                FlowLayoutPanelMusic.Controls[i].BackColor = Color.Transparent;
            }

            ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_Click(object sender, EventArgs e)
        {
            MusicPanel ClickedMusic = sender as MusicPanel;

            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                musicPanel.BackColor = Color.Transparent;

            ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void MusicPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MusicPanel ClickedMusic = sender as MusicPanel;

                //  Change the Background color of the Clicked Music Panel, and reset the others background color
                foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                    musicPanel.BackColor = Color.Transparent;
                ClickedMusic.BackColor = Color.FromArgb(28, 28, 28);

                //  Show the Context Menu Strip, on the Clicked Music Panel
                Point PointLowerLeft = new Point(0, ClickedMusic.Height);
                PointLowerLeft = ClickedMusic.PointToScreen(PointLowerLeft);
                this.MusicPanelContextMenuStrip.Show(PointLowerLeft);
            }
        }

        private async void AddItemsInListToTheMainList(List<string> List)
        {
            //  Initialize the list and Play the first music
            foreach (string item in List)
            {
                if (FileIsAudio(item))
                {
                    Musics.Add(item);
                    AddMusicToFlowLayoutPanel(item);
                }
                await Task.Delay(10);
            }
        }

        private bool FileIsAudio(string AudioFilePath)
        {
            bool Value = false;

            foreach (string AudioExtension in AudioExtensions)
            {
                if (AudioFilePath.ToLower().EndsWith(AudioExtension))
                {
                    Value = true;
                    break;
                }
            }
            return Value;
        }

        private void MusicInitialize(string path)
        {
            try
            {
                if (song != null) song.Dispose();
                song = new Song(path);

                MusicState = MusicState.Play;
                ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                PlayAndPauseToolStripMenuItem.Text = "Pause";

                PlaybackBarControl.Max = (int)song.GetSongLength().TotalSeconds;
                song.SetSongVolume(TrackBarVolumeState.Value / 10f);
                LabelMusicEndTime.Text = song.GetSongLength().ToString(@"mm\:ss");
                PictureBoxMusicCover.BackgroundImage = song.cover;
                this.Text = song.artist + " - " + song.title;

                if (!AppTimer.Enabled) AppTimer.Start();

                song.Play();

                //  Change the Current MusicPanel BackgroundColor, and reset the others
                foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
                {
                    if (musicPanel.MusicPath == path)
                        musicPanel.BackColor = Color.FromArgb(28, 28, 28);
                    else
                        musicPanel.BackColor = Color.Transparent;
                }

            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);
            }
        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            if (Musics.Count != 0)
            {
                if (MusicState == MusicState.Pause)
                {
                    if (CurrentMusicIndex == 0 && song == null)
                        MusicInitialize(Musics[CurrentMusicIndex]);
                    else
                    {
                        song.Play();

                        MusicState = MusicState.Play;
                        ButtonPlayPause.BackgroundImage = Properties.Resources.Pause;
                        PlayAndPauseToolStripMenuItem.Text = "Pause";
                    }
                }
                else if (MusicState == MusicState.Play)
                {
                    song.Pause();

                    MusicState = MusicState.Pause;
                    ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
                    PlayAndPauseToolStripMenuItem.Text = "Play";
                }
            }
            else
                OpenFilesToolStripMenuItem_Click(sender, e);
        }

        private void ButtonPrevieus_Click(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the first one on list, and the list isn't clear
            if (CurrentMusicIndex != 0 && Musics.Count != 0)
            {
                MusicInitialize(Musics[--CurrentMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[CurrentMusicIndex]);
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            //  Check if the Current Playing Music isn't the last one on list, and the list isn't clear
            //  and check if the LoopState equale All, to reapeat the Playlist from the first
            if (CurrentMusicIndex != Musics.Count - 1 && Musics.Count != 0)
            {
                MusicInitialize(Musics[++CurrentMusicIndex]);

                FlowLayoutPanelMusic.ScrollControlIntoView(FlowLayoutPanelMusic.Controls[CurrentMusicIndex]);
            }
            else if (CurrentMusicIndex == Musics.Count - 1)
            {
                CurrentMusicIndex = 0;
                MusicInitialize(Musics[CurrentMusicIndex]);

                if (LoopState == LoopState.Off)
                    ButtonPlayPause.PerformClick();
            }
        }

        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            if (Musics.Count != 0)
            {
                if (ShuffleState == ShuffleState.On)
                {
                    ShuffleState = ShuffleState.Off;
                    ShuffleToolStripMenuItem.Checked = false;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOff;

                    //  Order the list on the last SortedMethode
                    if (LastSortedMethode == SortedMethode.Title)
                        SortByTitleToolContextMenuStriItem.PerformClick();
                    else if (LastSortedMethode == SortedMethode.Album)
                        SortByAlbumToolContextMenuStriItem.PerformClick();
                    else if (LastSortedMethode == SortedMethode.Artist)
                        SortByArtistToolContextMenuStriItem.PerformClick();
                }
                else if (ShuffleState == ShuffleState.Off)
                {
                    ShuffleState = ShuffleState.On;
                    ShuffleToolStripMenuItem.Checked = true;
                    ButtonShuffle.BackgroundImage = Properties.Resources.shuffleOn;

                    SortByTitleToolContextMenuStriItem.Checked = false;
                    SortByArtistToolContextMenuStriItem.Checked = false;
                    SortByAlbumToolContextMenuStriItem.Checked = false;

                    TitleToolStripMenuItem.Checked = false;
                    ArtistToolStripMenuItem.Checked = false;
                    AlbumToolStripMenuItem.Checked = false;

                    Random rand = new Random();

                    //  Shuffle the List
                    List<string> ShuffledList = Musics.OrderBy((item) => rand.Next()).ToList();

                    // Clear the Lists and initialize the index and waveoutevent to null
                    ClearListToolStripMenuItem.PerformClick();

                    //  Initialize the list and Play the first music
                    AddItemsInListToTheMainList(ShuffledList);

                    MusicInitialize(Musics[CurrentMusicIndex]);
                }
            }
        }

        private void ButtonLoop_Click(object sender, EventArgs e)
        {
            if (LoopState == LoopState.One)
            {
                LoopState = LoopState.All;
                LoopModeAllToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
            }
            else if (LoopState == LoopState.All)
            {
                LoopState = LoopState.Off;
                LoopModeOffToolStripMenuItem.Checked = true;
                LoopModeOneToolStripMenuItem.Checked = false;
                LoopModeAllToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
            }
            else if (LoopState == LoopState.Off)
            {
                LoopState = LoopState.One;
                LoopModeOneToolStripMenuItem.Checked = true;
                LoopModeAllToolStripMenuItem.Checked = false;
                LoopModeOffToolStripMenuItem.Checked = false;
                ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
            }
        }

        private void LoopModeOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.One;
            LoopModeOneToolStripMenuItem.Checked = true;
            LoopModeAllToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOne;
        }

        private void LoopModeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.All;
            LoopModeAllToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeOffToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopAll;
        }

        private void LoopModeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopState = LoopState.Off;
            LoopModeOffToolStripMenuItem.Checked = true;
            LoopModeOneToolStripMenuItem.Checked = false;
            LoopModeAllToolStripMenuItem.Checked = false;
            ButtonLoop.BackgroundImage = Properties.Resources.LoopOff;
        }

        private void ChangedProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (song != null)
            {
                if (PlaybackBarControl.IsMouseDown)
                    song.SetSongPosition(PlaybackBarControl.Val);
            }
            else
                PlaybackBarControl.Val = 0;
        }

        private void TrackBarVolumeState_Scroll(object sender, EventArgs e)
        {
            if (song != null)
                song.SetSongVolume(TrackBarVolumeState.Value / 10f);
            else
                TrackBarVolumeState.Value = 10;
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            if (song != null)
            {
                //  Change the Label Text to the Music current Time
                LabelMusicCurrentTimeState.Text = song.GetCurrentTime().ToString(@"mm\:ss");

                //  Change the PlaybackBarControl value to the Music current Time
                PlaybackBarControl.Val = (int)song.GetCurrentTime().TotalSeconds;

                //  Check if the Music end, then start the Next one or repeat it
                if (song.GetCurrentTime().TotalSeconds == song.GetSongLength().TotalSeconds)
                {
                    if (LoopState == LoopState.One)
                        song.SetSongPosition(0);
                    else
                    {
                        MusicState = MusicState.Pause;
                        ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
                        PlayAndPauseToolStripMenuItem.Text = "Play";

                        ButtonNext.PerformClick();
                    }
                }
            }
        }

        private void StartSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
            {
                if (musicPanel.BackColor == Color.FromArgb(28, 28, 28))
                {
                    MusicPanel_DoubleClick(musicPanel, e);
                    break;
                }
            }
        }

        private void RemoveFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Search for the clicked MusicPanel and remove it
            foreach (MusicPanel musicPanel in FlowLayoutPanelMusic.Controls)
            {
                if (musicPanel.BackColor == Color.FromArgb(28, 28, 28))
                {
                    //  if the removed MusicPanel is the Playong Music, Start the next one
                    if (musicPanel.MusicPath == Musics[CurrentMusicIndex])
                        ButtonNext.PerformClick();

                    Musics.Remove(musicPanel.MusicPath);
                    FlowLayoutPanelMusic.Controls.Remove(musicPanel);

                    if (Musics.Count == 0)
                        ClearListToolStripMenuItem_Click(sender, e);

                    break;
                }
            }

            //  Initialize the CurrentPlayingMusicIndex with the correct index
            for (int i = 0; i < Musics.Count; i++)
            {
                if (this.Text == (song.artist + " - " + song.title))
                {
                    CurrentMusicIndex = i;
                    break;
                }
            }
        }

        private void ShowAndHideMusicListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FlowLayoutPanelMusic.Visible)
            {
                ShowAndHideMusicListToolStripMenuItem.Text = "Hide Music List";
                FlowLayoutPanelMusic.Visible = true;
            }
            else if (FlowLayoutPanelMusic.Visible)
            {
                ShowAndHideMusicListToolStripMenuItem.Text = "Show Music List";
                FlowLayoutPanelMusic.Visible = false;
            }
        }

        private void ShowSongLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Musics.Count != 0)
            {
                int index = -1;

                for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
                {
                    if (FlowLayoutPanelMusic.Controls[i].BackColor == Color.FromArgb(28, 28, 28))
                    {
                        index = i;
                        break;
                    }
                }

                if (index > -1)
                    new LyricsForm(Musics[index]) { Icon = this.Icon }.Show();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Musics.Count != 0)
                {
                    int index = -1;

                    for (int i = 0; i < FlowLayoutPanelMusic.Controls.Count; i++)
                    {
                        if (FlowLayoutPanelMusic.Controls[i].BackColor == Color.FromArgb(28, 28, 28))
                        {
                            index = i;
                            break;
                        }
                    }

                    if (index > -1)
                    {
                        EditForm editForm = new EditForm(Musics[index]) { Icon = this.Icon };

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            Song returnedSong = new Song(editForm.song.path, false);

                            (FlowLayoutPanelMusic.Controls[index] as MusicPanel).MusicPath = returnedSong.path;
                            (FlowLayoutPanelMusic.Controls[index] as MusicPanel).MusicTitle.Text = returnedSong.title;
                            (FlowLayoutPanelMusic.Controls[index] as MusicPanel).MusicCover.Image = returnedSong.cover.GetThumbnailImage(40, 40, null, IntPtr.Zero);

                            MessageBox.Show(returnedSong.ToString());
                        }
                    }
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

        private void SortByTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  I use the OrderBy function and the Linq, to sort the list on the title
            List<string> SortedList = Musics.OrderBy(o => Song.GetTitle(o)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(SortedList);

            MusicInitialize(Musics[CurrentMusicIndex]);

            LastSortedMethode = SortedMethode.Title;

            SortByTitleToolContextMenuStriItem.Checked = true;
            SortByArtistToolContextMenuStriItem.Checked = false;
            SortByAlbumToolContextMenuStriItem.Checked = false;

            TitleToolStripMenuItem.Checked = true;
            ArtistToolStripMenuItem.Checked = false;
            AlbumToolStripMenuItem.Checked = false;
        }

        private void SortByArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SortedList = Musics.OrderBy(x => Song.GetArtist(x)).ThenBy(x => Song.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();
            // The only reason make me keep All this Code bellow on comment, is that i found a better and small way to do it (The Line upove)
            #region The Comment Code
            /*  //  I use the OrderBy function and the Linq, to sort the list on the Album
            List<string> MusicListCopy = Music.OrderBy(o => TagFile.Album(o)).ToList();
            List<string> AllAlbumsName = new List<string>();

            foreach (var item in MusicListCopy)
                AllAlbumsName.Add(TagFile.Album(item));
            //  Reamove all the rapeated AlbumName on the list
            AllAlbumsName = AllAlbumsName.Distinct().ToList();

            List<string> SortedList = new List<string>();
            List<string> OnlyOneAlbumMusic = new List<string>();

            foreach (var ItemInAllAlbumsName in AllAlbumsName)
            {
                foreach (var ItemInMusic in Music)
                {
                    if (TagFile.Album(ItemInMusic) == ItemInAllAlbumsName)
                    {
                        OnlyOneAlbumMusic.Add(ItemInMusic);
                        MusicListCopy.Remove(ItemInMusic);
                    }
                }

                OnlyOneAlbumMusic = OnlyOneAlbumMusic.OrderBy(o => TagFile.Track(o)).ToList();

                foreach (var item in OnlyOneAlbumMusic)
                    SortedList.Add(item);
                OnlyOneAlbumMusic.Clear();
            }

            SortedList = SortedList.OrderBy(o => TagFile.Artist(o)).ToList();   */
            #endregion

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(SortedList);

            MusicInitialize(Musics[CurrentMusicIndex]);

            LastSortedMethode = SortedMethode.Artist;

            SortByArtistToolContextMenuStriItem.Checked = true;
            SortByTitleToolContextMenuStriItem.Checked = false;
            SortByAlbumToolContextMenuStriItem.Checked = false;

            ArtistToolStripMenuItem.Checked = true;
            TitleToolStripMenuItem.Checked = false;
            AlbumToolStripMenuItem.Checked = false;
        }

        private void SortByAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Sort thelist by the Album then the Track Number
            var SortedList = Musics.OrderBy(x => Song.GetAlbum(x)).ThenBy(x => TagFile.GetTrack(x)).ToList();

            // Clear the Lists and initialize the index and waveoutevent to null
            ClearListToolStripMenuItem.PerformClick();

            //  Initialize the list and Play the first music
            AddItemsInListToTheMainList(SortedList);

            MusicInitialize(Musics[CurrentMusicIndex]);

            LastSortedMethode = SortedMethode.Album;

            SortByAlbumToolContextMenuStriItem.Checked = true;
            SortByTitleToolContextMenuStriItem.Checked = false;
            SortByArtistToolContextMenuStriItem.Checked = false;

            AlbumToolStripMenuItem.Checked = true;
            TitleToolStripMenuItem.Checked = false;
            ArtistToolStripMenuItem.Checked = false;
        }

        private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppTimer.Stop();
            if (song != null) song.Dispose();

            FlowLayoutPanelMusic.Controls.Clear();
            Musics.Clear();

            LabelMusicCurrentTimeState.Text = "--:--";
            LabelMusicEndTime.Text = "--:--";

            CurrentMusicIndex = 0;
            PlaybackBarControl.Val = 0;

            PictureBoxMusicCover.BackgroundImage = Properties.Resources.MusicTon;
            ButtonPlayPause.BackgroundImage = Properties.Resources.Play;
            PlayAndPauseToolStripMenuItem.Text = "Play";
            MusicState = MusicState.Pause;

            this.Text = "MusicPlayer";
        }

        private void MusicPlayer_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MusicPlayer_DragDrop(object sender, DragEventArgs e)
        {
            List<string> OnlyAudioFiles = new List<string>();

            foreach (string FilePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //  Add only the Audio file to the List
                if (FileIsAudio(FilePath))
                    OnlyAudioFiles.Add(FilePath);
                else if (Directory.Exists(FilePath))
                {
                    //  Filter the Folder and Add only the Audio file to the List
                    var AllFilesPath = Directory.EnumerateFiles(FilePath, "*.*", SearchOption.AllDirectories);

                    foreach (var FilePathInList in AllFilesPath)
                        if (FileIsAudio(FilePathInList))
                            OnlyAudioFiles.Add(FilePathInList);
                }
            }

            AddItemsInListToTheMainList(OnlyAudioFiles);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm() { Icon = this.Icon }.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clear the Lists and initialize the index and song to null
            ClearListToolStripMenuItem.PerformClick();

            //  Delete the Temp Files
            if (Directory.Exists("TempFiles/"))
                Directory.Delete("TempFiles/", true);
        }

    }
}
