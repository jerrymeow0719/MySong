using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using NewSongList.Models;
using Xamarin.Forms;

namespace NewSongList.Views
{
    public partial class SongView : ContentPage
    {
        ObservableCollection<MySong> songList;
        SongRepository songRepository = new SongRepository();
        static int _nowPage;

        public SongView()
        {
            InitializeComponent();
            _nowPage = 1; // First page

            // List
            songList = new ObservableCollection<MySong>();
            lv.ItemsSource = songList;

            // Button
            btnType.Clicked += BtnType_Clicked;

            MySong test = new MySong { songname = "天黑請閉眼", singer = "陳零九＆邱鋒澤" };
            songList.Add(test);
            test = new MySong { songname = "天亮請睜眼", singer = "陳零九＆邱鋒澤" };
            songList.Add(test);
        }

        private async void BtnType_Clicked(object sender, EventArgs e)
        {
            await songRepository.GetNewSongAsync();
        }

        private void SetPage()
        {
            btnType.IsEnabled = false;
            switch (_nowPage)
            {
                case 1:
                case 2:
                    _nowPage++;
                    break;
                case 3:
                    _nowPage = 1;
                    break;
            }

            // Get data
            songList.Clear();

            btnType.IsEnabled = true;
        }
    }
}
