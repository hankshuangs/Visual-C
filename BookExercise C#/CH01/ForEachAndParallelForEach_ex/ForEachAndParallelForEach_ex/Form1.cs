using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent; //for Parallel Control and thread-safe

namespace ForEachAndParallelForEach_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            List<int> Data = new List<int>();
            int datacount = 10000;
            for (int i = 1; i <= datacount; i++)
            {
                Data.Add(i);
            }

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            int sum = 0;
            string msg = "";
            foreach (var i in Data)
            {
                sum = sum + i;
                string buf = String.Format("i={0},sum={1}\t", i, sum);
                msg = msg + buf;
            }
            sw.Stop();//碼錶停止
            string ForEachResult = sw.Elapsed.TotalMilliseconds.ToString();
            MessageBox.Show(string.Format("普通迴圈ForEach運行時長：{0}毫秒。\n{1}", ForEachResult, sum.ToString()));
        }

        private void btnParallelForEach_Click(object sender, EventArgs e)
        {
            List<int> TestData = new List<int>();//Collection非安全執行緒
            ConcurrentStack<int> Data = new ConcurrentStack<int>();//安全執行緒

            int datacount = 10000;
            for (int i = 1; i <= datacount; i++)
            {
                Data.Push(i);
            }

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            int sum = 0;
            string msg = "";
            object sync = new object();
            Parallel.ForEach(Data, new ParallelOptions {  MaxDegreeOfParallelism = 4}, (i) =>
            {
                int n;
                Data.TryPop(out n);
                lock (sync) //若沒有Lock則會因競爭而有資料遺失
                {
                    sum = sum + n;
                }
                string buf = String.Format("i={0},sum={1}\t", i, sum);
                msg = msg + buf;
            });
            sw.Stop();//碼錶停止
            string ParallelForEachResult = sw.Elapsed.TotalMilliseconds.ToString();
            MessageBox.Show(string.Format("平行ForEach迴圈運行時長：{0}毫秒。\n{1}", ParallelForEachResult, sum.ToString()));
        }
    }
}
