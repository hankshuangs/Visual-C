using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionMarkColon_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            double score = 0;
            string level = "";
            if (cboLevel.Text == "")
            {
                level = "大學部";
            }
            else
            {
                level = cboLevel.Text;
            }

            score = double.Parse(txtScore.Text);

            var result = (level == "研究所") ?
                ((score >= 70) ? "及格" : "被當") : ((score >= 60) ? "及格" : "被當");

            MessageBox.Show(level + "考試成績為" + score + "分," + result, "C#考試結果");
        }
    }
}
