using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int i, num, sum = 0;

            if (txtNum.Text == "")
            {
                num = 0;
            }
            else
            {
                num = int.Parse(txtNum.Text);
            }

            for (i = 0; i <= num; i++)
            {
                sum = sum + i;
            }

            MessageBox.Show("1+2+...+" + num + "=" + sum);
        }
    }
}
