using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_Append
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

            StringBuilder SB = new StringBuilder(s1);
            SB.Append(s2);

            MessageBox.Show(SB.ToString(), "Append()方法");
        }
    }
}
