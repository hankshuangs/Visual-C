using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryExpressions_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string msg = "103年度-第一學期-C#程式設計考試及格成績:\n";
            // LINQ資料來源為陣列物件集合
            int[] scores = new int[] { 58 , 65 , 71 , 49 , 95 ,
                                       83 , 56 , 60 , 79 , 64 , 85 , 49 ,
                                       55 , 87 , 59 , 73 , 100};

            // 定義查詢運算式
            var scoreQuery =
                from score in scores
                where score >= 60
                orderby score
                select score;

            // 執行查詢
            foreach (var obj in scoreQuery)
            {
                msg = msg + obj + " ";
            }
            MessageBox.Show(msg, "[物件集合]查詢運算式");
        }
    }
}
