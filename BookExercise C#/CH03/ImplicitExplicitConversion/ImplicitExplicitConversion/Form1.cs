using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplicitExplicitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImplicit_Click(object sender, EventArgs e)
        {
            int score = 100;
            double d = 0;
            d = score; //進行隱含轉換，資料不會因此失真
            MessageBox.Show("考試成績=" + d.ToString(), "隱含轉換");
        }

        private void btnExplicit_Click(object sender, EventArgs e)
        {
            double score = 99.9;
            int i1 = 0, i2 = 0;
            i1 = (int)score; //進行明確轉換，資料會失真
            i2 = System.Convert.ToInt32(score);
            string msg = "考試成績=" + i1.ToString() + " (cast明確轉換)\n";
            msg = msg + "考試成績=" + i2.ToString() + " (convert明確轉換)";
            MessageBox.Show(msg, "明確轉換方式");
        }
    }
}
