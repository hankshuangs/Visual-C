using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveNtier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int num = N_tier(n);
            string msg = txtN.Text + "! = " + num;
            MessageBox.Show(msg, "求解N階層");
        }
        public int N_tier(int N)
        {
            if (N == 1) //終止條件
            {
                return 1;
            }
            else
            {
                return N * N_tier(N - 1); //遞迴條件
            }
        }
    }
}
