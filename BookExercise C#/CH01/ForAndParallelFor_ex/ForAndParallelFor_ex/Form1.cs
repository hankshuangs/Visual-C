using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ForAndParallelFor_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string msg = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            for (int i = 1; i <= 10000; i++)
            {
                    sum = sum + i;
                    string buf = String.Format("i={0},sum={1}\t", i, sum);
                    msg = msg + buf;
            }
            sw.Stop();//碼錶停止
            string ForResult = sw.Elapsed.TotalMilliseconds.ToString();
            MessageBox.Show(string.Format("普通迴圈For運行時長：{0}毫秒。\n{1}", ForResult, sum.ToString()));
        }

        private void btnParallelFor_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string msg = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            object sync = new object();
            Parallel.For(1, 10001, new ParallelOptions { MaxDegreeOfParallelism = 4 }, (i) =>
            {
                lock (sync) //若沒有Lock則會因競爭而有資料遺失
                {
                    sum = sum + i;
                }
                string buf = String.Format("i={0},sum={1}\t", i, sum);
                msg = msg + buf;
            });
            sw.Stop();//碼錶停止
            string ParallelForResult = sw.Elapsed.TotalMilliseconds.ToString();
            MessageBox.Show(string.Format("平行For迴圈運行時長：{0}毫秒。\n{1}", ParallelForResult, sum.ToString()));
        }
    }
}
