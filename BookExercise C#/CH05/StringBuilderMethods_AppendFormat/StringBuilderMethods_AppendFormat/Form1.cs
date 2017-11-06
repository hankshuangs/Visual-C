using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_AppendFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double prices = 1500000;
            string s1 = "Mitsubishi Eclipse 2014\n售價=";
            StringBuilder SB = new StringBuilder(s1);

            SB.AppendFormat("{0:C}元", prices);
            MessageBox.Show(SB.ToString(), "AppendFormat()方法");
        }
    }
}
