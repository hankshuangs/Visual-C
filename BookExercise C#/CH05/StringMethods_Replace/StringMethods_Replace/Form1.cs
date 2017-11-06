using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "Microsoft Visual Basic 2013";
            string s2 = s1.Replace("Visual Basic", "Visual C#");

            string msg = "原先的字串為:" + s1 + "\n";
            msg = msg + "取代後字串為:" + s2;
            MessageBox.Show(msg, "Replace()方法");
        }
    }
}
