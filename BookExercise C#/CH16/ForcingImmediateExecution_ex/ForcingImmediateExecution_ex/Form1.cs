using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForcingImmediateExecution_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[] scores = new int[12] { 59 , 77 , 86 ,42, 62 , 55 ,
                                         97 , 82 , 73 , 46 , 99 ,57 };

            var scoreQuery = from score in scores
                             where score >= 60
                             select score;

            string msg = "分數大於等於60分相關分析:\n";

            int count = scoreQuery.Count();
            double average = scoreQuery.Average();
            double sum = scoreQuery.Sum();
            int max = scoreQuery.Max();
            int min = scoreQuery.Min();

            msg = msg + "資料筆數:" + count + "\n";
            msg = msg + "平均:" + average + "\n";
            msg = msg + "總分:" + sum + "\n";
            msg = msg + "最高分:" + max + "\n";
            msg = msg + "最低分:" + min;
            MessageBox.Show(msg, "強制立即查詢");
        }
    }
}
