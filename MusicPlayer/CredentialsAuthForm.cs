using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class CredentialsAuthForm : Form
    {
        public CredentialsAuthForm()
        {
            InitializeComponent();
        }

        private void CredentialsAuthForm_Load(object sender, EventArgs e)
        {
            TextBoxClientId.Text = Properties.Settings.Default.ClientId;
            TextBoxClientSecret.Text = Properties.Settings.Default.ClientSecret;
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CredentialsAuth auth = new CredentialsAuth(TextBoxClientId.Text, TextBoxClientSecret.Text);
                Token token = await auth.GetToken();

                if (!String.IsNullOrWhiteSpace(token.TokenType) && !String.IsNullOrWhiteSpace(token.AccessToken))
                {
                    Properties.Settings.Default.ClientId = auth.ClientId;
                    Properties.Settings.Default.ClientSecret = auth.ClientSecret;
                    Properties.Settings.Default.TokenType = token.TokenType;
                    Properties.Settings.Default.AccessToken = token.AccessToken;
                    Properties.Settings.Default.Save();

                    this.DialogResult = DialogResult.OK;
                }
                else
                    token = null;
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);
            }
        }
    }
}
