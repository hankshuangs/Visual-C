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

namespace ComboBox_ex
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            cboMember.Items.Add("行政院院長：江宜樺");
            cboMember.Items.Add("內政部部長：李鴻源");
            cboMember.Items.Add("外交部部長：林永樂");
            cboMember.Items.Add("國防部部長：嚴明");
            cboMember.Items.Add("經濟部部長：張家祝");
            cboMember.Items.Add("教育部部長：蔣偉寧");
            btnAdd.IsEnabled = false;
            messageBox("新內閣成員加入完畢!!");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cboMember.Items.Clear();
            btnAdd.IsEnabled = true;
            messageBox("完成內閣總辭!!");
        }

        private void btnGetItems_Click(object sender, RoutedEventArgs e)
        {
            string msg = "新內閣成員如下:\n";
            foreach (var obj in cboMember.Items)
            {
                msg = msg + obj + "\n";
            }
            msg = msg + "總計:" + cboMember.Items.Count + "人";
            messageBox(msg + " ,ComboBox範例");
        }

        private void cboMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMember.SelectedItem != null)
            {
                string msg = "您選取的內閣成員為:" + cboMember.SelectedItem;
                messageBox(msg + " ,SelectionChanged事件");
            }
        }

        protected async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
        }
    }
}
