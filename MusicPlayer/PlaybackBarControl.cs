﻿using System.Windows.Forms;
using System.Drawing;
using System;

namespace MusicPlayer
{
    public partial class PlaybackBarControl : UserControl
    {
        private Point MousPosition;
        public bool IsMouseDown;
        private int val;

        public int Max { get; set; } = 100;

        public int Val
        {
            get { return val; }
            set
            {
                if (value >= 0 && value < Max)
                {
                    val = value;

                    if (Max != 0)
                        ChangedProgressPanel.Left = (value * ProgressBarPanel.Width) / Max;
                }
            }
        }

        public PlaybackBarControl()
        {
            InitializeComponent();

            val = 0;

            ConfigPlaybackBarControlColor();
        }

        private void ChangedProgressPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = true;
                MousPosition = new Point(e.X, e.Y);
            }

        }

        private void ChangedProgressPanel_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void ChangedProgressPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point NewPosition = new Point((ChangedProgressPanel.Left + (e.X - MousPosition.X)), ChangedProgressPanel.Top);

                if (NewPosition.X >= ProgressBarPanel.Location.X && NewPosition.X <= (ProgressBarPanel.Width - ChangedProgressPanel.Width))
                    ChangedProgressPanel.Location = NewPosition;
            }
        }

        private void PlaybackBarControl_Resize(object sender, EventArgs e)
        {
            ChangedProgressPanel.Height = this.Height;
            ProgressBarPanel.Width = this.Width;
            ConfigPlaybackBarControlColor();
        }

        private void ChangedProgressPanel_LocationChanged(object sender, EventArgs e)
        {
            if (ProgressBarPanel.Width != 0)
            {
                val = (ChangedProgressPanel.Location.X * Max) / ProgressBarPanel.Width;
                ConfigPlaybackBarControlColor();
            }
        }

        void ConfigPlaybackBarControlColor()
        {
            ProgressBarPanel.CreateGraphics().Clear(ProgressBarPanel.BackColor);
            ProgressBarPanel.CreateGraphics().FillRectangle(Brushes.DarkSlateGray, new Rectangle(0, 0, ChangedProgressPanel.Left, ProgressBarPanel.Height));
        }

    }

}

