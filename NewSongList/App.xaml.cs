using System;
using NewSongList.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewSongList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new SongView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
