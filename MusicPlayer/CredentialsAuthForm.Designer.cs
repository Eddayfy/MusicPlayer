namespace MusicPlayer
{
    partial class CredentialsAuthForm
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
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.TextBoxClientId = new System.Windows.Forms.TextBox();
            this.LabelClientId = new System.Windows.Forms.Label();
            this.LabelClientSecret = new System.Windows.Forms.Label();
            this.TextBoxClientSecret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ButtonSubmit.Location = new System.Drawing.Point(97, 221);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(190, 33);
            this.ButtonSubmit.TabIndex = 41;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // TextBoxClientId
            // 
            this.TextBoxClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxClientId.Location = new System.Drawing.Point(45, 59);
            this.TextBoxClientId.Name = "TextBoxClientId";
            this.TextBoxClientId.Size = new System.Drawing.Size(327, 26);
            this.TextBoxClientId.TabIndex = 40;
            // 
            // LabelClientId
            // 
            this.LabelClientId.Location = new System.Drawing.Point(12, 14);
            this.LabelClientId.Name = "LabelClientId";
            this.LabelClientId.Size = new System.Drawing.Size(360, 37);
            this.LabelClientId.TabIndex = 42;
            this.LabelClientId.Text = "Your Client ID:";
            this.LabelClientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelClientSecret
            // 
            this.LabelClientSecret.Location = new System.Drawing.Point(12, 104);
            this.LabelClientSecret.Name = "LabelClientSecret";
            this.LabelClientSecret.Size = new System.Drawing.Size(360, 37);
            this.LabelClientSecret.TabIndex = 44;
            this.LabelClientSecret.Text = "Your Client Secret:";
            this.LabelClientSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxClientSecret
            // 
            this.TextBoxClientSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBoxClientSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClientSecret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.TextBoxClientSecret.Location = new System.Drawing.Point(45, 149);
            this.TextBoxClientSecret.Name = "TextBoxClientSecret";
            this.TextBoxClientSecret.Size = new System.Drawing.Size(327, 26);
            this.TextBoxClientSecret.TabIndex = 43;
            // 
            // CredentialsAuthForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.LabelClientSecret);
            this.Controls.Add(this.TextBoxClientSecret);
            this.Controls.Add(this.LabelClientId);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextBoxClientId);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CredentialsAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Credentials Auth";
            this.Load += new System.EventHandler(this.CredentialsAuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox TextBoxClientId;
        private System.Windows.Forms.Label LabelClientId;
        private System.Windows.Forms.Label LabelClientSecret;
        private System.Windows.Forms.TextBox TextBoxClientSecret;
    }
}