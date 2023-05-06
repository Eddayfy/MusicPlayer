namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelMusicCurrentTimeState = new System.Windows.Forms.Label();
            this.LabelMusicEndTime = new System.Windows.Forms.Label();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.TrackBarVolumeState = new System.Windows.Forms.TrackBar();
            this.ButtonPrevieus = new System.Windows.Forms.Button();
            this.ButtonShuffle = new System.Windows.Forms.Button();
            this.ButtonLoop = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonShowAndHideList = new System.Windows.Forms.Button();
            this.ButtonPlayPause = new System.Windows.Forms.Button();
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayAndPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrevieusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EditSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopModeOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopModeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAndHideMusicListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAndHideSongLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicPanelContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowMusicLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByTitleToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByArtistToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByAlbumToolContextMenuStriItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxMusicCover = new System.Windows.Forms.Panel();
            this.FlowLayoutPanelMusic = new System.Windows.Forms.FlowLayoutPanel();
            this.PlaybackBarControl = new MusicPlayer.PlaybackBarControl();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolumeState)).BeginInit();
            this.AppMenuStrip.SuspendLayout();
            this.MusicPanelContextMenuStrip.SuspendLayout();
            this.PictureBoxMusicCover.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMusicCurrentTimeState
            // 
            this.LabelMusicCurrentTimeState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelMusicCurrentTimeState.AutoSize = true;
            this.LabelMusicCurrentTimeState.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.LabelMusicCurrentTimeState.Location = new System.Drawing.Point(321, 16);
            this.LabelMusicCurrentTimeState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMusicCurrentTimeState.Name = "LabelMusicCurrentTimeState";
            this.LabelMusicCurrentTimeState.Size = new System.Drawing.Size(51, 19);
            this.LabelMusicCurrentTimeState.TabIndex = 0;
            this.LabelMusicCurrentTimeState.Text = "--:--";
            // 
            // LabelMusicEndTime
            // 
            this.LabelMusicEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMusicEndTime.AutoSize = true;
            this.LabelMusicEndTime.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.LabelMusicEndTime.Location = new System.Drawing.Point(1008, 16);
            this.LabelMusicEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMusicEndTime.Name = "LabelMusicEndTime";
            this.LabelMusicEndTime.Size = new System.Drawing.Size(51, 19);
            this.LabelMusicEndTime.TabIndex = 0;
            this.LabelMusicEndTime.Text = "--:--";
            // 
            // PanelControls
            // 
            this.PanelControls.BackColor = System.Drawing.Color.Black;
            this.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControls.Controls.Add(this.PlaybackBarControl);
            this.PanelControls.Controls.Add(this.TrackBarVolumeState);
            this.PanelControls.Controls.Add(this.ButtonPrevieus);
            this.PanelControls.Controls.Add(this.LabelMusicEndTime);
            this.PanelControls.Controls.Add(this.LabelMusicCurrentTimeState);
            this.PanelControls.Controls.Add(this.ButtonShuffle);
            this.PanelControls.Controls.Add(this.ButtonLoop);
            this.PanelControls.Controls.Add(this.ButtonNext);
            this.PanelControls.Controls.Add(this.ButtonShowAndHideList);
            this.PanelControls.Controls.Add(this.ButtonPlayPause);
            this.PanelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControls.ForeColor = System.Drawing.Color.White;
            this.PanelControls.Location = new System.Drawing.Point(0, 512);
            this.PanelControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(1245, 55);
            this.PanelControls.TabIndex = 0;
            // 
            // TrackBarVolumeState
            // 
            this.TrackBarVolumeState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarVolumeState.BackColor = System.Drawing.Color.Black;
            this.TrackBarVolumeState.Location = new System.Drawing.Point(1087, -1);
            this.TrackBarVolumeState.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBarVolumeState.Name = "TrackBarVolumeState";
            this.TrackBarVolumeState.Size = new System.Drawing.Size(143, 56);
            this.TrackBarVolumeState.TabIndex = 0;
            this.TrackBarVolumeState.TabStop = false;
            this.TrackBarVolumeState.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarVolumeState.Value = 10;
            this.TrackBarVolumeState.Scroll += new System.EventHandler(this.TrackBarVolumeState_Scroll);
            // 
            // ButtonPrevieus
            // 
            this.ButtonPrevieus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPrevieus.BackColor = System.Drawing.Color.Black;
            this.ButtonPrevieus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPrevieus.BackgroundImage")));
            this.ButtonPrevieus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPrevieus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevieus.FlatAppearance.BorderSize = 0;
            this.ButtonPrevieus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevieus.Location = new System.Drawing.Point(15, 11);
            this.ButtonPrevieus.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPrevieus.Name = "ButtonPrevieus";
            this.ButtonPrevieus.Size = new System.Drawing.Size(40, 31);
            this.ButtonPrevieus.TabIndex = 0;
            this.ButtonPrevieus.TabStop = false;
            this.ButtonPrevieus.UseVisualStyleBackColor = false;
            this.ButtonPrevieus.Click += new System.EventHandler(this.ButtonPrevieus_Click);
            // 
            // ButtonShuffle
            // 
            this.ButtonShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonShuffle.BackColor = System.Drawing.Color.Black;
            this.ButtonShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonShuffle.BackgroundImage")));
            this.ButtonShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShuffle.FlatAppearance.BorderSize = 0;
            this.ButtonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShuffle.Location = new System.Drawing.Point(264, 11);
            this.ButtonShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonShuffle.Name = "ButtonShuffle";
            this.ButtonShuffle.Size = new System.Drawing.Size(40, 31);
            this.ButtonShuffle.TabIndex = 0;
            this.ButtonShuffle.TabStop = false;
            this.ButtonShuffle.UseVisualStyleBackColor = false;
            this.ButtonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
            // 
            // ButtonLoop
            // 
            this.ButtonLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonLoop.BackColor = System.Drawing.Color.Black;
            this.ButtonLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoop.BackgroundImage")));
            this.ButtonLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoop.FlatAppearance.BorderSize = 0;
            this.ButtonLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoop.Location = new System.Drawing.Point(224, 11);
            this.ButtonLoop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLoop.Name = "ButtonLoop";
            this.ButtonLoop.Size = new System.Drawing.Size(40, 31);
            this.ButtonLoop.TabIndex = 0;
            this.ButtonLoop.TabStop = false;
            this.ButtonLoop.UseVisualStyleBackColor = false;
            this.ButtonLoop.Click += new System.EventHandler(this.ButtonLoop_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonNext.BackColor = System.Drawing.Color.Black;
            this.ButtonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNext.BackgroundImage")));
            this.ButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Location = new System.Drawing.Point(124, 11);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(40, 31);
            this.ButtonNext.TabIndex = 0;
            this.ButtonNext.TabStop = false;
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonShowAndHideList
            // 
            this.ButtonShowAndHideList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonShowAndHideList.BackColor = System.Drawing.Color.Black;
            this.ButtonShowAndHideList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonShowAndHideList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowAndHideList.FlatAppearance.BorderSize = 0;
            this.ButtonShowAndHideList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowAndHideList.Location = new System.Drawing.Point(184, 11);
            this.ButtonShowAndHideList.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonShowAndHideList.Name = "ButtonShowAndHideList";
            this.ButtonShowAndHideList.Size = new System.Drawing.Size(40, 31);
            this.ButtonShowAndHideList.TabIndex = 0;
            this.ButtonShowAndHideList.TabStop = false;
            this.ButtonShowAndHideList.UseVisualStyleBackColor = false;
            this.ButtonShowAndHideList.Click += new System.EventHandler(this.ShowAndHideMusicListToolStripMenuItem_Click);
            // 
            // ButtonPlayPause
            // 
            this.ButtonPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPlayPause.BackColor = System.Drawing.Color.Black;
            this.ButtonPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPlayPause.BackgroundImage")));
            this.ButtonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlayPause.FlatAppearance.BorderSize = 0;
            this.ButtonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlayPause.Location = new System.Drawing.Point(63, 1);
            this.ButtonPlayPause.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPlayPause.Name = "ButtonPlayPause";
            this.ButtonPlayPause.Size = new System.Drawing.Size(53, 49);
            this.ButtonPlayPause.TabIndex = 0;
            this.ButtonPlayPause.TabStop = false;
            this.ButtonPlayPause.UseVisualStyleBackColor = false;
            this.ButtonPlayPause.Click += new System.EventHandler(this.ButtonPlayPause_Click);
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AppMenuStrip.Size = new System.Drawing.Size(1245, 28);
            this.AppMenuStrip.TabIndex = 20;
            this.AppMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.OpenFileToolStripMenuItem.Text = "&Open File";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFilesToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.OpenToolStripMenuItem.Text = "&Open Folder";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(264, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayAndPauseToolStripMenuItem,
            this.NextToolStripMenuItem,
            this.PrevieusToolStripMenuItem,
            this.toolStripSeparator3,
            this.EditSongToolStripMenuItem,
            this.SortByToolStripMenuItem,
            this.toolStripSeparator4,
            this.ShuffleToolStripMenuItem,
            this.LoopModeToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // PlayAndPauseToolStripMenuItem
            // 
            this.PlayAndPauseToolStripMenuItem.Name = "PlayAndPauseToolStripMenuItem";
            this.PlayAndPauseToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.PlayAndPauseToolStripMenuItem.Text = "Play";
            this.PlayAndPauseToolStripMenuItem.Click += new System.EventHandler(this.ButtonPlayPause_Click);
            // 
            // NextToolStripMenuItem
            // 
            this.NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            this.NextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.NextToolStripMenuItem.Text = "&Next";
            this.NextToolStripMenuItem.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // PrevieusToolStripMenuItem
            // 
            this.PrevieusToolStripMenuItem.Name = "PrevieusToolStripMenuItem";
            this.PrevieusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrevieusToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.PrevieusToolStripMenuItem.Text = "&Previeus";
            this.PrevieusToolStripMenuItem.Click += new System.EventHandler(this.ButtonPrevieus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // EditSongToolStripMenuItem
            // 
            this.EditSongToolStripMenuItem.Name = "EditSongToolStripMenuItem";
            this.EditSongToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.EditSongToolStripMenuItem.Text = "Edit Song";
            this.EditSongToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // SortByToolStripMenuItem
            // 
            this.SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleToolStripMenuItem,
            this.ArtistToolStripMenuItem,
            this.AlbumToolStripMenuItem});
            this.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            this.SortByToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.SortByToolStripMenuItem.Text = "Sort by:";
            // 
            // TitleToolStripMenuItem
            // 
            this.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            this.TitleToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.TitleToolStripMenuItem.Text = "Title";
            this.TitleToolStripMenuItem.Click += new System.EventHandler(this.SortByTitleToolStripMenuItem_Click);
            // 
            // ArtistToolStripMenuItem
            // 
            this.ArtistToolStripMenuItem.Name = "ArtistToolStripMenuItem";
            this.ArtistToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.ArtistToolStripMenuItem.Text = "Artist";
            this.ArtistToolStripMenuItem.Click += new System.EventHandler(this.SortByArtistToolStripMenuItem_Click);
            // 
            // AlbumToolStripMenuItem
            // 
            this.AlbumToolStripMenuItem.Name = "AlbumToolStripMenuItem";
            this.AlbumToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.AlbumToolStripMenuItem.Text = "Album";
            this.AlbumToolStripMenuItem.Click += new System.EventHandler(this.SortByAlbumToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // ShuffleToolStripMenuItem
            // 
            this.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem";
            this.ShuffleToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.ShuffleToolStripMenuItem.Text = "Shuffle Play";
            this.ShuffleToolStripMenuItem.Click += new System.EventHandler(this.ButtonShuffle_Click);
            // 
            // LoopModeToolStripMenuItem
            // 
            this.LoopModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoopModeOneToolStripMenuItem,
            this.LoopModeAllToolStripMenuItem,
            this.LoopModeOffToolStripMenuItem});
            this.LoopModeToolStripMenuItem.Name = "LoopModeToolStripMenuItem";
            this.LoopModeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.LoopModeToolStripMenuItem.Text = "Loop Mode";
            // 
            // LoopModeOneToolStripMenuItem
            // 
            this.LoopModeOneToolStripMenuItem.Name = "LoopModeOneToolStripMenuItem";
            this.LoopModeOneToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.LoopModeOneToolStripMenuItem.Text = "One";
            this.LoopModeOneToolStripMenuItem.Click += new System.EventHandler(this.LoopModeOneToolStripMenuItem_Click);
            // 
            // LoopModeAllToolStripMenuItem
            // 
            this.LoopModeAllToolStripMenuItem.Name = "LoopModeAllToolStripMenuItem";
            this.LoopModeAllToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.LoopModeAllToolStripMenuItem.Text = "All";
            this.LoopModeAllToolStripMenuItem.Click += new System.EventHandler(this.LoopModeAllToolStripMenuItem_Click);
            // 
            // LoopModeOffToolStripMenuItem
            // 
            this.LoopModeOffToolStripMenuItem.Checked = true;
            this.LoopModeOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoopModeOffToolStripMenuItem.Name = "LoopModeOffToolStripMenuItem";
            this.LoopModeOffToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.LoopModeOffToolStripMenuItem.Text = "Off";
            this.LoopModeOffToolStripMenuItem.Click += new System.EventHandler(this.LoopModeOffToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAndHideMusicListToolStripMenuItem,
            this.ShowAndHideSongLyricsToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // ShowAndHideMusicListToolStripMenuItem
            // 
            this.ShowAndHideMusicListToolStripMenuItem.Name = "ShowAndHideMusicListToolStripMenuItem";
            this.ShowAndHideMusicListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ShowAndHideMusicListToolStripMenuItem.Text = "Hide Music List";
            this.ShowAndHideMusicListToolStripMenuItem.Click += new System.EventHandler(this.ShowAndHideMusicListToolStripMenuItem_Click);
            // 
            // ShowAndHideSongLyricsToolStripMenuItem
            // 
            this.ShowAndHideSongLyricsToolStripMenuItem.Name = "ShowAndHideSongLyricsToolStripMenuItem";
            this.ShowAndHideSongLyricsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ShowAndHideSongLyricsToolStripMenuItem.Text = "Show Music Lyrics";
            this.ShowAndHideSongLyricsToolStripMenuItem.Click += new System.EventHandler(this.ShowSongLyricsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // AppTimer
            // 
            this.AppTimer.Enabled = true;
            this.AppTimer.Tick += new System.EventHandler(this.AppTimer_Tick);
            // 
            // MusicPanelContextMenuStrip
            // 
            this.MusicPanelContextMenuStrip.BackColor = System.Drawing.Color.White;
            this.MusicPanelContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MusicPanelContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSongToolStripMenuItem,
            this.RemoveFromListToolStripMenuItem,
            this.toolStripSeparator1,
            this.ShowMusicLyricsToolStripMenuItem,
            this.EditToolStripMenuItem1,
            this.SortByToolContextMenuStriItem,
            this.toolStripSeparator2,
            this.ClearListToolStripMenuItem});
            this.MusicPanelContextMenuStrip.Name = "MusicPanelContextMenuStrip";
            this.MusicPanelContextMenuStrip.Size = new System.Drawing.Size(211, 188);
            // 
            // StartSongToolStripMenuItem
            // 
            this.StartSongToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.StartSongToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.StartSongToolStripMenuItem.Name = "StartSongToolStripMenuItem";
            this.StartSongToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.StartSongToolStripMenuItem.Text = "Start this Song";
            this.StartSongToolStripMenuItem.Click += new System.EventHandler(this.StartSongToolStripMenuItem_Click);
            // 
            // RemoveFromListToolStripMenuItem
            // 
            this.RemoveFromListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.RemoveFromListToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.RemoveFromListToolStripMenuItem.Name = "RemoveFromListToolStripMenuItem";
            this.RemoveFromListToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.RemoveFromListToolStripMenuItem.Text = "Remove From List";
            this.RemoveFromListToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ShowMusicLyricsToolStripMenuItem
            // 
            this.ShowMusicLyricsToolStripMenuItem.Name = "ShowMusicLyricsToolStripMenuItem";
            this.ShowMusicLyricsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ShowMusicLyricsToolStripMenuItem.Text = "Show Music Lyrics";
            this.ShowMusicLyricsToolStripMenuItem.Click += new System.EventHandler(this.ShowSongLyricsToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem1
            // 
            this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            this.EditToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.EditToolStripMenuItem1.Text = "Edit";
            this.EditToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // SortByToolContextMenuStriItem
            // 
            this.SortByToolContextMenuStriItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByTitleToolContextMenuStriItem,
            this.SortByArtistToolContextMenuStriItem,
            this.SortByAlbumToolContextMenuStriItem});
            this.SortByToolContextMenuStriItem.Name = "SortByToolContextMenuStriItem";
            this.SortByToolContextMenuStriItem.Size = new System.Drawing.Size(210, 24);
            this.SortByToolContextMenuStriItem.Text = "Sort by:";
            // 
            // SortByTitleToolContextMenuStriItem
            // 
            this.SortByTitleToolContextMenuStriItem.Name = "SortByTitleToolContextMenuStriItem";
            this.SortByTitleToolContextMenuStriItem.Size = new System.Drawing.Size(136, 26);
            this.SortByTitleToolContextMenuStriItem.Text = "Title";
            this.SortByTitleToolContextMenuStriItem.Click += new System.EventHandler(this.SortByTitleToolStripMenuItem_Click);
            // 
            // SortByArtistToolContextMenuStriItem
            // 
            this.SortByArtistToolContextMenuStriItem.Name = "SortByArtistToolContextMenuStriItem";
            this.SortByArtistToolContextMenuStriItem.Size = new System.Drawing.Size(136, 26);
            this.SortByArtistToolContextMenuStriItem.Text = "Artist";
            this.SortByArtistToolContextMenuStriItem.Click += new System.EventHandler(this.SortByArtistToolStripMenuItem_Click);
            // 
            // SortByAlbumToolContextMenuStriItem
            // 
            this.SortByAlbumToolContextMenuStriItem.Name = "SortByAlbumToolContextMenuStriItem";
            this.SortByAlbumToolContextMenuStriItem.Size = new System.Drawing.Size(136, 26);
            this.SortByAlbumToolContextMenuStriItem.Text = "Album";
            this.SortByAlbumToolContextMenuStriItem.Click += new System.EventHandler(this.SortByAlbumToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // ClearListToolStripMenuItem
            // 
            this.ClearListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ClearListToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem";
            this.ClearListToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ClearListToolStripMenuItem.Text = "Clear List";
            this.ClearListToolStripMenuItem.Click += new System.EventHandler(this.ClearListToolStripMenuItem_Click);
            // 
            // PictureBoxMusicCover
            // 
            this.PictureBoxMusicCover.BackColor = System.Drawing.Color.Black;
            this.PictureBoxMusicCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMusicCover.BackgroundImage")));
            this.PictureBoxMusicCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxMusicCover.Controls.Add(this.FlowLayoutPanelMusic);
            this.PictureBoxMusicCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxMusicCover.Location = new System.Drawing.Point(0, 28);
            this.PictureBoxMusicCover.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxMusicCover.Name = "PictureBoxMusicCover";
            this.PictureBoxMusicCover.Size = new System.Drawing.Size(1245, 484);
            this.PictureBoxMusicCover.TabIndex = 0;
            // 
            // FlowLayoutPanelMusic
            // 
            this.FlowLayoutPanelMusic.AutoScroll = true;
            this.FlowLayoutPanelMusic.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlowLayoutPanelMusic.ForeColor = System.Drawing.Color.White;
            this.FlowLayoutPanelMusic.Location = new System.Drawing.Point(998, 0);
            this.FlowLayoutPanelMusic.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanelMusic.Name = "FlowLayoutPanelMusic";
            this.FlowLayoutPanelMusic.Size = new System.Drawing.Size(247, 484);
            this.FlowLayoutPanelMusic.TabIndex = 0;
            // 
            // PlaybackBarControl
            // 
            this.PlaybackBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaybackBarControl.BackColor = System.Drawing.Color.Transparent;
            this.PlaybackBarControl.Location = new System.Drawing.Point(384, 14);
            this.PlaybackBarControl.Margin = new System.Windows.Forms.Padding(5);
            this.PlaybackBarControl.Max = 100;
            this.PlaybackBarControl.Name = "PlaybackBarControl";
            this.PlaybackBarControl.Size = new System.Drawing.Size(616, 26);
            this.PlaybackBarControl.TabIndex = 1;
            this.PlaybackBarControl.Val = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1245, 567);
            this.Controls.Add(this.PictureBoxMusicCover);
            this.Controls.Add(this.AppMenuStrip);
            this.Controls.Add(this.PanelControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MusicPlayer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MusicPlayer_DragEnter);
            this.PanelControls.ResumeLayout(false);
            this.PanelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolumeState)).EndInit();
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.MusicPanelContextMenuStrip.ResumeLayout(false);
            this.PictureBoxMusicCover.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PictureBoxMusicCover;
        private System.Windows.Forms.Button ButtonPlayPause;
        private System.Windows.Forms.Button ButtonPrevieus;
        private System.Windows.Forms.Button ButtonShowAndHideList;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLoop;
        private System.Windows.Forms.Button ButtonShuffle;
        private System.Windows.Forms.Label LabelMusicCurrentTimeState;
        private System.Windows.Forms.Label LabelMusicEndTime;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayAndPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrevieusToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ShuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAndHideMusicListToolStripMenuItem;
        private System.Windows.Forms.TrackBar TrackBarVolumeState;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelMusic;
        private System.Windows.Forms.Timer AppTimer;
        private PlaybackBarControl PlaybackBarControl;
        private System.Windows.Forms.ContextMenuStrip MusicPanelContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ShowAndHideSongLyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByTitleToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByArtistToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem SortByAlbumToolContextMenuStriItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoopModeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowMusicLyricsToolStripMenuItem;
    }
}