using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelOfBreakStop_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string msg = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            object sync = new object();
            Parallel.For(1, 11, (i , LoopState) =>
            {
                if (i == 5)
                    LoopState.Break();
                lock (sync) //若沒有Lock則會因競爭而有資料遺失
                {
                    sum = sum + i;
                }
                string buf = String.Format("i={0},sum={1}\n", i, sum);
                msg = msg + buf;
            });
            sw.Stop();//碼錶停止
            string ParallelForResult = sw.Elapsed.TotalMilliseconds.ToString();
            rtxtResult.Text = string.Format("Break執行結束：{0}毫秒。\n{1}", ParallelForResult, msg);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string msg = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            object sync = new object();
            Parallel.For(1, 11, (i, LoopState) =>
            {
                if (i == 5)
                    LoopState.Stop();
                lock (sync) //若沒有Lock則會因競爭而有資料遺失
                {
                    sum = sum + i;
                }
                string buf = String.Format("i={0},sum={1}\n", i, sum);
                msg = msg + buf;
            });
            sw.Stop();//碼錶停止
            string ParallelForResult = sw.Elapsed.TotalMilliseconds.ToString();
            rtxtResult.Text = string.Format("Stop執行結束：{0}毫秒。\n{1}", ParallelForResult, msg);
        }
    }
}
