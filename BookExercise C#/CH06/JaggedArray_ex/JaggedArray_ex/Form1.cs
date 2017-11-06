using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaggedArray_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string[][] advisor = new string[3][];

            advisor[0] = new string[] { "王巾瓶", "進退得宜", "出奇制勝", "穩紮穩打" };
            advisor[1] = new string[] { "王跪酚", "喜歡演戲", "擅於爭辯" };
            advisor[2] = new string[] { "高震慄", "擅長加料" };

            string msg = "";
            int i, j;

            for (i = 0; i < advisor.Length; i++)
            {
                for (j = 0; j < advisor[i].Length; j++)
                {
                    msg = msg + advisor[i][j] + "\t";
                }
                msg = msg + Environment.NewLine;
            }

            MessageBox.Show(this, msg, "指導教授收學生條件");
        }
    }
}
