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

namespace TextBox_ex
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string SN = "ABCDE-12345-67890";
            if (txtSN.Text == SN)
            {
                messageBox("註冊碼正確已經完成註冊!! , 訊息");
            }
            else
            {
                if (txtSN.Text == "")
                {
                    messageBox("註冊碼不可為空白!! , 警告");
                    
                }
                else
                {
                    messageBox("註冊碼錯誤請聯絡軟體廠商!! , 訊息");
                }
            }
        }

        protected async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtSN.Text = "";
        }

        private void txtSN_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtSN.Text.Length ==20)
            {
                messageBox("註冊碼長度最多20個字元 , TextChanged事件");
            }
        }
    }
}
