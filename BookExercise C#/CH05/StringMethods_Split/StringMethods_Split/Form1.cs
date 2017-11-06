using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string dateStr = "2014/3/22";

            string[] dateArray = dateStr.Split('/');

            string msg = dateArray[0] + "年 " +
                         dateArray[1] + "月 " +
                         dateArray[2] + "日 ";

            MessageBox.Show(msg, "Split()方法");
        }
    }
}
