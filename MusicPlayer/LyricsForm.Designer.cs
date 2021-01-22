namespace MusicPlayer
{
    partial class LyricsForm
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
            this.hr = new System.Windows.Forms.Panel();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.RichTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            this.EditeLyricsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // hr
            // 
            this.hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hr.Location = new System.Drawing.Point(33, 393);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(539, 2);
            this.hr.TabIndex = 67;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSave.Location = new System.Drawing.Point(433, 401);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 63;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonClose.Location = new System.Drawing.Point(514, 401);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 66;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // RichTextBoxLyrics
            // 
            this.RichTextBoxLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RichTextBoxLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.RichTextBoxLyrics.Location = new System.Drawing.Point(12, 12);
            this.RichTextBoxLyrics.Name = "RichTextBoxLyrics";
            this.RichTextBoxLyrics.ReadOnly = true;
            this.RichTextBoxLyrics.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxLyrics.Size = new System.Drawing.Size(578, 369);
            this.RichTextBoxLyrics.TabIndex = 0;
            this.RichTextBoxLyrics.TabStop = false;
            this.RichTextBoxLyrics.Text = "";
            this.RichTextBoxLyrics.TextChanged += new System.EventHandler(this.RichTextBoxLyrics_TextChanged);
            // 
            // EditeLyricsCheckBox
            // 
            this.EditeLyricsCheckBox.AutoSize = true;
            this.EditeLyricsCheckBox.Location = new System.Drawing.Point(12, 401);
            this.EditeLyricsCheckBox.Name = "EditeLyricsCheckBox";
            this.EditeLyricsCheckBox.Size = new System.Drawing.Size(100, 23);
            this.EditeLyricsCheckBox.TabIndex = 70;
            this.EditeLyricsCheckBox.Text = "Edit Lyrics";
            this.EditeLyricsCheckBox.UseVisualStyleBackColor = true;
            this.EditeLyricsCheckBox.CheckedChanged += new System.EventHandler(this.EditeLyricsCheckBox_CheckedChanged);
            // 
            // LyricsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.EditeLyricsCheckBox);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.RichTextBoxLyrics);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LyricsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyricsForm";
            this.Load += new System.EventHandler(this.LyricsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RichTextBox RichTextBoxLyrics;
        private System.Windows.Forms.CheckBox EditeLyricsCheckBox;
    }
}