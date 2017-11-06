using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchVariables_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 0;
            int sum = 0;
            num = 10;
            num = num + 10;
            sum = 30;
            sum = sum + num;
            num = num + 20;
            sum = sum + num;
            MessageBox.Show("sum=" + sum, "監看式視窗");
        }
    }
}
