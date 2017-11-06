using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderAttribute_Chars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string msg = "Visual C# 2013";

            StringBuilder SB = new StringBuilder(msg);

            char c = SB[7];

            MessageBox.Show(c.ToString(), "Chars屬性");
        }
    }
}
