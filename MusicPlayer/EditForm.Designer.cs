namespace MusicPlayer
{
    partial class EditForm
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
            this.ButtonChooseCover = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelArtists = new System.Windows.Forms.Label();
            this.TextBoxArtist = new System.Windows.Forms.TextBox();
            this.LabelAlbumArtist = new System.Windows.Forms.Label();
            this.TextBoxAlbumArtist = new System.Windows.Forms.TextBox();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.TextBoxAlbum = new System.Windows.Forms.TextBox();
            this.TextBoxComposers = new System.Windows.Forms.TextBox();
            this.LabelComposers = new System.Windows.Forms.Label();
            this.TextBoxTrack = new System.Windows.Forms.TextBox();
            this.LabelTrack = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelLyrics = new System.Windows.Forms.Label();
            this.TextBoxGrouping = new System.Windows.Forms.TextBox();
            this.LabelGrouping = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.TextBoxTrackCount = new System.Windows.Forms.TextBox();
            this.LabelTrackOf = new System.Windows.Forms.Label();
            this.TextBoxDiscCount = new System.Windows.Forms.TextBox();
            this.LabelDiscOf = new System.Windows.Forms.Label();
            this.TextBoxDisc = new System.Windows.Forms.TextBox();
            this.LabelDisc = new System.Windows.Forms.Label();
            this.RichTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            this.PictureBoxCover = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevieus = new System.Windows.Forms.Button();
            this.hr = new System.Windows.Forms.Panel();
            this.RadioButtonRTL = new System.Windows.Forms.RadioButton();
            this.RadioButtonLTR = new System.Windows.Forms.RadioButton();
            this.ButtonAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonChooseCover
            // 
            this.ButtonChooseCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonChooseCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChooseCover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonChooseCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChooseCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonChooseCover.Location = new System.Drawing.Point(12, 218);
            this.ButtonChooseCover.Name = "ButtonChooseCover";
            this.ButtonChooseCover.Size = new System.Drawing.Size(200, 30);
            this.ButtonChooseCover.TabIndex = 1;
            this.ButtonChooseCover.Text = "Choose Picture";
            this.ButtonChooseCover.UseVisualStyleBackColor = false;
            this.ButtonChooseCover.Click += new System.EventHandler(this.ButtonChooseCover_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTitle.Location = new System.Drawing.Point(232, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(79, 17);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Track Title:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTitle.Location = new System.Drawing.Point(338, 9);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(250, 23);
            this.TextBoxTitle.TabIndex = 3;
            // 
            // LabelArtists
            // 
            this.LabelArtists.AutoSize = true;
            this.LabelArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArtists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelArtists.Location = new System.Drawing.Point(232, 41);
            this.LabelArtists.Name = "LabelArtists";
            this.LabelArtists.Size = new System.Drawing.Size(51, 17);
            this.LabelArtists.TabIndex = 2;
            this.LabelArtists.Text = "Artists:";
            // 
            // TextBoxArtist
            // 
            this.TextBoxArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxArtist.Location = new System.Drawing.Point(338, 38);
            this.TextBoxArtist.Name = "TextBoxArtist";
            this.TextBoxArtist.Size = new System.Drawing.Size(250, 23);
            this.TextBoxArtist.TabIndex = 3;
            // 
            // LabelAlbumArtist
            // 
            this.LabelAlbumArtist.AutoSize = true;
            this.LabelAlbumArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbumArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelAlbumArtist.Location = new System.Drawing.Point(232, 70);
            this.LabelAlbumArtist.Name = "LabelAlbumArtist";
            this.LabelAlbumArtist.Size = new System.Drawing.Size(87, 17);
            this.LabelAlbumArtist.TabIndex = 2;
            this.LabelAlbumArtist.Text = "Album Artist:";
            // 
            // TextBoxAlbumArtist
            // 
            this.TextBoxAlbumArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxAlbumArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAlbumArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAlbumArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxAlbumArtist.Location = new System.Drawing.Point(338, 67);
            this.TextBoxAlbumArtist.Name = "TextBoxAlbumArtist";
            this.TextBoxAlbumArtist.Size = new System.Drawing.Size(250, 23);
            this.TextBoxAlbumArtist.TabIndex = 3;
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.AutoSize = true;
            this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelAlbum.Location = new System.Drawing.Point(232, 99);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(51, 17);
            this.LabelAlbum.TabIndex = 2;
            this.LabelAlbum.Text = "Album:";
            // 
            // TextBoxAlbum
            // 
            this.TextBoxAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxAlbum.Location = new System.Drawing.Point(338, 96);
            this.TextBoxAlbum.Name = "TextBoxAlbum";
            this.TextBoxAlbum.Size = new System.Drawing.Size(250, 23);
            this.TextBoxAlbum.TabIndex = 3;
            // 
            // TextBoxComposers
            // 
            this.TextBoxComposers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxComposers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxComposers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxComposers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxComposers.Location = new System.Drawing.Point(338, 125);
            this.TextBoxComposers.Name = "TextBoxComposers";
            this.TextBoxComposers.Size = new System.Drawing.Size(250, 23);
            this.TextBoxComposers.TabIndex = 8;
            // 
            // LabelComposers
            // 
            this.LabelComposers.AutoSize = true;
            this.LabelComposers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComposers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelComposers.Location = new System.Drawing.Point(232, 128);
            this.LabelComposers.Name = "LabelComposers";
            this.LabelComposers.Size = new System.Drawing.Size(83, 17);
            this.LabelComposers.TabIndex = 4;
            this.LabelComposers.Text = "Composers:";
            // 
            // TextBoxTrack
            // 
            this.TextBoxTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTrack.Location = new System.Drawing.Point(89, 269);
            this.TextBoxTrack.Name = "TextBoxTrack";
            this.TextBoxTrack.Size = new System.Drawing.Size(45, 23);
            this.TextBoxTrack.TabIndex = 10;
            this.TextBoxTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTrack
            // 
            this.LabelTrack.AutoSize = true;
            this.LabelTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTrack.Location = new System.Drawing.Point(12, 272);
            this.LabelTrack.Name = "LabelTrack";
            this.LabelTrack.Size = new System.Drawing.Size(48, 17);
            this.LabelTrack.TabIndex = 6;
            this.LabelTrack.Text = "Track:";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxYear.Location = new System.Drawing.Point(89, 327);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(123, 23);
            this.TextBoxYear.TabIndex = 11;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelYear.Location = new System.Drawing.Point(12, 330);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(42, 17);
            this.LabelYear.TabIndex = 7;
            this.LabelYear.Text = "Year:";
            // 
            // LabelLyrics
            // 
            this.LabelLyrics.AutoSize = true;
            this.LabelLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelLyrics.Location = new System.Drawing.Point(232, 186);
            this.LabelLyrics.Name = "LabelLyrics";
            this.LabelLyrics.Size = new System.Drawing.Size(49, 17);
            this.LabelLyrics.TabIndex = 12;
            this.LabelLyrics.Text = "Lyrics:";
            // 
            // TextBoxGrouping
            // 
            this.TextBoxGrouping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxGrouping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGrouping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxGrouping.Location = new System.Drawing.Point(338, 154);
            this.TextBoxGrouping.Name = "TextBoxGrouping";
            this.TextBoxGrouping.Size = new System.Drawing.Size(250, 23);
            this.TextBoxGrouping.TabIndex = 17;
            // 
            // LabelGrouping
            // 
            this.LabelGrouping.AutoSize = true;
            this.LabelGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGrouping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelGrouping.Location = new System.Drawing.Point(232, 157);
            this.LabelGrouping.Name = "LabelGrouping";
            this.LabelGrouping.Size = new System.Drawing.Size(71, 17);
            this.LabelGrouping.TabIndex = 13;
            this.LabelGrouping.Text = "Grouping:";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxGenre.Location = new System.Drawing.Point(89, 356);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(123, 23);
            this.TextBoxGenre.TabIndex = 18;
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelGenre.Location = new System.Drawing.Point(12, 359);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(59, 17);
            this.LabelGenre.TabIndex = 15;
            this.LabelGenre.Text = "Genres:";
            // 
            // TextBoxTrackCount
            // 
            this.TextBoxTrackCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxTrackCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTrackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTrackCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxTrackCount.Location = new System.Drawing.Point(167, 269);
            this.TextBoxTrackCount.Name = "TextBoxTrackCount";
            this.TextBoxTrackCount.Size = new System.Drawing.Size(45, 23);
            this.TextBoxTrackCount.TabIndex = 21;
            this.TextBoxTrackCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTrackOf
            // 
            this.LabelTrackOf.AutoSize = true;
            this.LabelTrackOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrackOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelTrackOf.Location = new System.Drawing.Point(138, 272);
            this.LabelTrackOf.Name = "LabelTrackOf";
            this.LabelTrackOf.Size = new System.Drawing.Size(23, 17);
            this.LabelTrackOf.TabIndex = 20;
            this.LabelTrackOf.Text = "Of";
            // 
            // TextBoxDiscCount
            // 
            this.TextBoxDiscCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxDiscCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDiscCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDiscCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxDiscCount.Location = new System.Drawing.Point(167, 298);
            this.TextBoxDiscCount.Name = "TextBoxDiscCount";
            this.TextBoxDiscCount.Size = new System.Drawing.Size(45, 23);
            this.TextBoxDiscCount.TabIndex = 29;
            this.TextBoxDiscCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelDiscOf
            // 
            this.LabelDiscOf.AutoSize = true;
            this.LabelDiscOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDiscOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelDiscOf.Location = new System.Drawing.Point(138, 301);
            this.LabelDiscOf.Name = "LabelDiscOf";
            this.LabelDiscOf.Size = new System.Drawing.Size(23, 17);
            this.LabelDiscOf.TabIndex = 28;
            this.LabelDiscOf.Text = "Of";
            // 
            // TextBoxDisc
            // 
            this.TextBoxDisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxDisc.Location = new System.Drawing.Point(89, 298);
            this.TextBoxDisc.Name = "TextBoxDisc";
            this.TextBoxDisc.Size = new System.Drawing.Size(45, 23);
            this.TextBoxDisc.TabIndex = 27;
            this.TextBoxDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelDisc
            // 
            this.LabelDisc.AutoSize = true;
            this.LabelDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDisc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.LabelDisc.Location = new System.Drawing.Point(12, 301);
            this.LabelDisc.Name = "LabelDisc";
            this.LabelDisc.Size = new System.Drawing.Size(39, 17);
            this.LabelDisc.TabIndex = 26;
            this.LabelDisc.Text = "Disc:";
            // 
            // RichTextBoxLyrics
            // 
            this.RichTextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RichTextBoxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.RichTextBoxLyrics.Location = new System.Drawing.Point(338, 183);
            this.RichTextBoxLyrics.Name = "RichTextBoxLyrics";
            this.RichTextBoxLyrics.Size = new System.Drawing.Size(250, 196);
            this.RichTextBoxLyrics.TabIndex = 30;
            this.RichTextBoxLyrics.Text = "";
            // 
            // PictureBoxCover
            // 
            this.PictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxCover.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxCover.Name = "PictureBoxCover";
            this.PictureBoxCover.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxCover.TabIndex = 0;
            this.PictureBoxCover.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.Location = new System.Drawing.Point(513, 399);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 31;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.Location = new System.Drawing.Point(432, 399);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 31;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonNext.Location = new System.Drawing.Point(69, 399);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(51, 23);
            this.ButtonNext.TabIndex = 31;
            this.ButtonNext.Text = "=>";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevieus
            // 
            this.ButtonPrevieus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonPrevieus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrevieus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonPrevieus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrevieus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonPrevieus.Location = new System.Drawing.Point(12, 399);
            this.ButtonPrevieus.Name = "ButtonPrevieus";
            this.ButtonPrevieus.Size = new System.Drawing.Size(51, 23);
            this.ButtonPrevieus.TabIndex = 31;
            this.ButtonPrevieus.Text = "<=";
            this.ButtonPrevieus.UseVisualStyleBackColor = false;
            this.ButtonPrevieus.Click += new System.EventHandler(this.ButtonPrevieus_Click);
            // 
            // hr
            // 
            this.hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hr.Location = new System.Drawing.Point(32, 391);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(539, 2);
            this.hr.TabIndex = 32;
            // 
            // RadioButtonRTL
            // 
            this.RadioButtonRTL.AutoSize = true;
            this.RadioButtonRTL.Location = new System.Drawing.Point(245, 241);
            this.RadioButtonRTL.Name = "RadioButtonRTL";
            this.RadioButtonRTL.Size = new System.Drawing.Size(87, 17);
            this.RadioButtonRTL.TabIndex = 33;
            this.RadioButtonRTL.Text = "Right To Left";
            this.RadioButtonRTL.UseVisualStyleBackColor = true;
            this.RadioButtonRTL.CheckedChanged += new System.EventHandler(this.RadioButtonRTL_CheckedChanged);
            // 
            // RadioButtonLTR
            // 
            this.RadioButtonLTR.AutoSize = true;
            this.RadioButtonLTR.Checked = true;
            this.RadioButtonLTR.Location = new System.Drawing.Point(245, 218);
            this.RadioButtonLTR.Name = "RadioButtonLTR";
            this.RadioButtonLTR.Size = new System.Drawing.Size(87, 17);
            this.RadioButtonLTR.TabIndex = 33;
            this.RadioButtonLTR.TabStop = true;
            this.RadioButtonLTR.Text = "Left To Right";
            this.RadioButtonLTR.UseVisualStyleBackColor = true;
            this.RadioButtonLTR.CheckedChanged += new System.EventHandler(this.RadioButtonLTR_CheckedChanged);
            // 
            // ButtonAuto
            // 
            this.ButtonAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonAuto.Location = new System.Drawing.Point(351, 399);
            this.ButtonAuto.Name = "ButtonAuto";
            this.ButtonAuto.Size = new System.Drawing.Size(75, 23);
            this.ButtonAuto.TabIndex = 34;
            this.ButtonAuto.Text = "Auto";
            this.ButtonAuto.UseVisualStyleBackColor = false;
            this.ButtonAuto.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.ButtonAuto);
            this.Controls.Add(this.RadioButtonLTR);
            this.Controls.Add(this.RadioButtonRTL);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.ButtonPrevieus);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.RichTextBoxLyrics);
            this.Controls.Add(this.TextBoxDiscCount);
            this.Controls.Add(this.LabelDiscOf);
            this.Controls.Add(this.TextBoxDisc);
            this.Controls.Add(this.LabelDisc);
            this.Controls.Add(this.TextBoxTrackCount);
            this.Controls.Add(this.LabelTrackOf);
            this.Controls.Add(this.LabelLyrics);
            this.Controls.Add(this.TextBoxGrouping);
            this.Controls.Add(this.LabelGrouping);
            this.Controls.Add(this.TextBoxGenre);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.TextBoxComposers);
            this.Controls.Add(this.LabelComposers);
            this.Controls.Add(this.TextBoxTrack);
            this.Controls.Add(this.LabelTrack);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TextBoxAlbum);
            this.Controls.Add(this.LabelAlbum);
            this.Controls.Add(this.TextBoxAlbumArtist);
            this.Controls.Add(this.LabelAlbumArtist);
            this.Controls.Add(this.TextBoxArtist);
            this.Controls.Add(this.LabelArtists);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonChooseCover);
            this.Controls.Add(this.PictureBoxCover);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxCover;
        private System.Windows.Forms.Button ButtonChooseCover;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelArtists;
        private System.Windows.Forms.TextBox TextBoxArtist;
        private System.Windows.Forms.Label LabelAlbumArtist;
        private System.Windows.Forms.TextBox TextBoxAlbumArtist;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.TextBox TextBoxAlbum;
        private System.Windows.Forms.TextBox TextBoxComposers;
        private System.Windows.Forms.Label LabelComposers;
        private System.Windows.Forms.TextBox TextBoxTrack;
        private System.Windows.Forms.Label LabelTrack;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelLyrics;
        private System.Windows.Forms.TextBox TextBoxGrouping;
        private System.Windows.Forms.Label LabelGrouping;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox TextBoxTrackCount;
        private System.Windows.Forms.Label LabelTrackOf;
        private System.Windows.Forms.TextBox TextBoxDiscCount;
        private System.Windows.Forms.Label LabelDiscOf;
        private System.Windows.Forms.TextBox TextBoxDisc;
        private System.Windows.Forms.Label LabelDisc;
        private System.Windows.Forms.RichTextBox RichTextBoxLyrics;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevieus;
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.RadioButton RadioButtonRTL;
        private System.Windows.Forms.RadioButton RadioButtonLTR;
        private System.Windows.Forms.Button ButtonAuto;
    }
}