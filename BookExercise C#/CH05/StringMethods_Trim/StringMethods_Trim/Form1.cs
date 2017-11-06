using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "  Have a crush on someone  ";
            int n1 = s1.Length;

            string s2 = s1.Trim();

            int n2 = s2.Length;
            string msg = "原字串:[" + s1 + "],字串長度=" + n1 + "\n";
            msg = msg + "去空白:[" + s2 + "],字串長度= " + n2;
            MessageBox.Show(msg, "Trim()方法");
        }
    }
}
