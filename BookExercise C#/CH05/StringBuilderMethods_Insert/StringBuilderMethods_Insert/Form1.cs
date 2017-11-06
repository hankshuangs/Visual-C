using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "";
            string s1 = "C#考試及格!!";
            StringBuilder SB = new StringBuilder(s1);

            SB.Insert(4, "不");

            msg = "原始字串:" + s1 + "\n";
            msg = msg + "插入後字串:" + SB.ToString();
            MessageBox.Show(msg, "Insert()方法");
        }
    }
}
