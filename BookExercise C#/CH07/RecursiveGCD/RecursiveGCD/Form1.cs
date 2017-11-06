using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveGCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int X = int.Parse(txtX.Text);
            int Y = int.Parse(txtY.Text);

            int maxGCD = 0;

            maxGCD = GCD(X, Y);
            string msg = "X = " + X + ", Y = " + Y + "\n";
            msg = msg + "最大公因數=" + maxGCD;
            MessageBox.Show(msg, "求解GCD");
        }
        public int GCD(int M, int N)
        {
            if (M % N == 0) //終止條件
            {
                return N;
            }
            else
            {
                return GCD(N, M % N); //遞迴條件
            }
        }
    }
}
