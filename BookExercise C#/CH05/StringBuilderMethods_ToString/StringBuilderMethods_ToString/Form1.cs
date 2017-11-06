using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_ToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "恭喜您，已經閱讀完本章^_^";
            StringBuilder SB = new StringBuilder(s1);

            string msg = SB.ToString();

            MessageBox.Show(msg, "ToString()方法");
        }
    }
}
