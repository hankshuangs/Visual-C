using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = "博碩科技瀏覽器 - " + webBrowser1.DocumentTitle;
            tSSL_NowStatus.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            tSTB_URL.Text = webBrowser1.Url.OriginalString;
        }

        //上一頁
        private void tSB_GoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        //下一頁
        private void tSB_GoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        //停止
        private void tSB_Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
        //重新整理
        private void tSB_Refresh_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
        //首頁
        private void tSB_GoHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        //搜尋
        private void tSB_GoSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }
        //移至
        private void tSB_Go_Click(object sender, EventArgs e)
        {
            if (tSTB_URL.Text != "")
            {
                webBrowser1.Navigate(tSTB_URL.Text);
            }
        }
    }
}
