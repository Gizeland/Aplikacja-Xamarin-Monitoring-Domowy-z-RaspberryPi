using System;
using System.Collections.Generic;
using LibVLCSharp.Shared;
using Xamarin.Forms;

namespace loginCamera
{
    public partial class PlayerPage : ContentPage
    {
        LibVLC _libvlc;
        public PlayerPage()
        {
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            PlayerInit();
        }

        private void PlayerInit()
        {
            var media = new Media(_libvlc, MainPage.playerUri, FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }

        private void btBackClick(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
            myVideo.MediaPlayer.Stop();
        }
    }
}
