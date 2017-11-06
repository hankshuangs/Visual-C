using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int i, j, k;
            string msg = "";

            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    k = i * j;
                    msg = msg + "[" + i + "*" + j + "=" + k + "]";
                }
                msg = msg + "\n";
            }

            richTextBox1.Text = msg;
        }
    }
}
