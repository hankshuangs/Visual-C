﻿using System;
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

namespace CheckBox_ex
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string msg = "";
            int count = 0;
            foreach (var obj in stackPanel1.Children)
            {
                CheckBox chx = (CheckBox)obj;
                if (chx.IsChecked == true)
                {
                    count = count + 1;
                    msg = msg + count.ToString() + ". " +
                        chx.Content.ToString() + "\n";
                }
            }
            if (count >1)
            { msg = msg + "您具有多重國籍身分!!最好不要擔任公職"; }
            messageBox(msg);
        }
        protected async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
        }
    }
}