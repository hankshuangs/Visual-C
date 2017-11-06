using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClient_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client Client =
                     new ServiceReference1.Service1Client();
            double N1 = double.Parse(txt_A.Text);
            double N2 = double.Parse(txt_B.Text);
            double sum = Client.Add(N1, N2);
            MessageBox.Show("A+B=" + sum.ToString());
        }
    }
}
