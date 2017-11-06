using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_ToCharArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            char[] letter = s1.ToCharArray();

            string msg = "第13個英文字母是" + letter[12];
            MessageBox.Show(msg, "ToCharArray()方法");
        }
    }
}
