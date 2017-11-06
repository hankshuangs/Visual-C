using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderAttribute_Length
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "Chiu Chien Chi ";
            StringBuilder SB = new StringBuilder(s1);

            int len = SB.Length;

            string msg = "原字串:" + s1 + "\n";
            msg = msg + "字元總數:" + len;
            MessageBox.Show(msg, "Length屬性");
        }
    }
}
