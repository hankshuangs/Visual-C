using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepCode_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtN.Text);
            int total;
            total = Add(num);
            string msg = "";
            msg = "1 + 2 +...+ " + num.ToString() + " =" + total.ToString();
            MessageBox.Show(msg, "數字累加計算");
        }
        public int Add(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
