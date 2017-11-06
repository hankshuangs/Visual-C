using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ref_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double score = 66; //須明確初始化變數
            string msg = "原分數=" + score + "\n";

            AddScore(ref score);

            msg = msg + "開根號乘以10後分數=" + score.ToString("F2");
            MessageBox.Show(msg, "ref參數範例");
        }
        public void AddScore(ref double num)
        {
            num = Math.Sqrt(num) * 10; //開根號乘以10
        }
    }
}
