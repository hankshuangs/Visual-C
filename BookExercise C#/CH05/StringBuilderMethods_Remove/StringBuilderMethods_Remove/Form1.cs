using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderMethods_Remove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string s1 = "Supra、RX-7、Skyline、Fairlady、NSX、3000GT";
            StringBuilder SB = new StringBuilder(s1);

            SB.Remove(10, 8);//剩下Supra、RX-7、Fairlady、NSX、3000GT
            SB.Remove(11, 9);//剩下Supra、RX-7、NSX、3000GT

            string msg = "東瀛跑車六傑:" + s1 + "\n";
            msg = msg + "東瀛跑車四大天王:" + SB.ToString();
            MessageBox.Show(msg, "Remove()方法");
        }
    }
}
