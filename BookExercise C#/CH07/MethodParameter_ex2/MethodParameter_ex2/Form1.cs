using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodParameter_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);

            IntNums objIN = new IntNums();
            objIN.m = A;
            objIN.n = B;

            string msg = "";
            msg = msg + "互換前整數A=" + objIN.m + " B=" + objIN.n + "\n";
            swap(objIN);
            msg = msg + "互換後整數A=" + objIN.m + " B=" + objIN.n;
            MessageBox.Show(msg, "數值交換");
        }
        void swap(IntNums intObj)
        {
            int temp;
            temp = intObj.m;
            intObj.m = intObj.n;
            intObj.n = temp;
        }
    }
    class IntNums
    {
        public int m;
        public int n;
    }
}
