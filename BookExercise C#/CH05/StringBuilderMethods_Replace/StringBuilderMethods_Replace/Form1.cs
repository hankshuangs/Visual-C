using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "As long as you wish to be beautiful,";
            string s2 = "you will be beautiful.";

            StringBuilder SB = new StringBuilder(s1 + s2);

            SB.Replace("beautiful", "rich");

            string msg = "原始字串:" + s1 + s2 + "\n";
            msg = msg + "取代後字串:" + SB.ToString();

            MessageBox.Show(msg, "Replace()方法");
        }
    }
}
