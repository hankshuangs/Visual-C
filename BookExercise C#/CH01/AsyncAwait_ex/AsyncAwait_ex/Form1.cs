using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http; // 加入System.Net.Http.dll參考

namespace AsyncAwait_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            rtxtResult.Text = "";
            int contentCount = await GetWebAsync();

            rtxtResult.Text +=
                String.Format("\r\n網頁資料獲取完畢，下載字元數共:{0} 個.\r\n", contentCount);
        }

        async Task<int> GetWebAsync()
        {
            //需加入 System.Net.Http.dll 參考
            HttpClient client = new HttpClient();

            //若沒有輸入任何網址資料，則預設是跑到Google網站
            var URL = (txtURL.Text == "") ? "http://www.google.com.tw" : txtURL.Text;
            Task<string> getStringTask = client.GetStringAsync(URL);

            // 下面方法會獨立工作不會等待GetStringAsync()方法
            NoWaitingWork();

            // await運算子會暫停GetWebAsync.
            // GetWebAsync不能繼續要等getStringTask完成工作
            string urlChars = await getStringTask;

            // 須回傳整數型態
            return urlChars.Length;
        }

        void NoWaitingWork()
        {
            rtxtResult.Text += "非同步工作進行中等待取得網頁資料 . . . . . . .\r\n";
        }
    }
}
