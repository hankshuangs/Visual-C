using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalArgument_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute1_Click(object sender, EventArgs e)
        {
            int sum;
            sum = ComputeSum(10);
        }

        private void btnCompute2_Click(object sender, EventArgs e)
        {
            txtN.Text = ComputeSum(10, false).ToString();
        }

        public int ComputeSum(int n, bool IsShowMsgBox = true)
        {
            int sum;
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            if (IsShowMsgBox == true)
            {
                MessageBox.Show("(1+2+..+" + n.ToString() + ")加總結果:" + sum.ToString());
            }
            return sum;
        }

    }
}
