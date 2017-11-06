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
using Windows.UI.Xaml.Media.Imaging;
// 空白頁項目範本已記錄在 http://go.microsoft.com/fwlink/?LinkId=234238

namespace Button_ex
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

        private void btnChangeContent_Click(object sender, RoutedEventArgs e)
        {
            btnDemo.Content = "展示按鈕";
        }

        private void btnResize_Click(object sender, RoutedEventArgs e)
        {
            btnDemo.Height = 150;
            btnDemo.Width = 500;
        }

        private void btnIsVisible_Click(object sender, RoutedEventArgs e)
        {
            
            btnDemo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void btnBackground_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush blueBrush = new SolidColorBrush(Windows.UI.Colors.Blue);
            btnDemo.Background = blueBrush;
        }
    }
}
