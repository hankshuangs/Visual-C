using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白頁項目範本已記錄在 http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppBar_ex
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        List<string> photos = new List<string>();
        int nowIndex;
        private void apBtnPlay_Click(object sender, RoutedEventArgs e)
        {
            nowIndex = 0;
            photos.Clear();
            photos.Add("ms-appx:///Assets/photo01.png");
            photos.Add("ms-appx:///Assets/photo02.png");
            photos.Add("ms-appx:///Assets/photo03.png");
            photos.Add("ms-appx:///Assets/photo04.png");
            photos.Add("ms-appx:///Assets/photo05.png");
            ImgPhotos.Width = 800;
            ImgPhotos.Height = 600;
            var bitmapImage = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(photos[nowIndex]));
            ImgPhotos.Stretch = Stretch.Uniform;
            ImgPhotos.Source = bitmapImage;
        }

        private void apBtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (nowIndex >=1)
            {
                nowIndex = nowIndex - 1;
                var bitmapImage = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(photos[nowIndex]));
                ImgPhotos.Stretch = Stretch.Uniform;
                ImgPhotos.Source = bitmapImage;
            }
        }

        private void apBtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (nowIndex < 4)
            {
                nowIndex = nowIndex + 1;
                var bitmapImage = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(photos[nowIndex]));
                ImgPhotos.Stretch = Stretch.Uniform;
                ImgPhotos.Source = bitmapImage;
            }
        }



        private void apBtnCSharp_Click(object sender, RoutedEventArgs e)
        {
            messageBox("這是用C#2013所開發照片輪播器的市集應用程式");
        }

        protected async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
        }
    }
}
