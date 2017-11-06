using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Substring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "我最愛的摩托車是GTS300i";

            string s2 = s1.Substring(8, 7);

            string msg = "原先字串:" + s1 + "\n";
            msg = msg + "取出字串:" + s2;
            MessageBox.Show(msg, "Substring");
        }
    }
}
